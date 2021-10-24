using AutoMapper;
using BLL.Dtos;
using BLL.Exceptions;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Exceptions;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        private IConfiguration Configuration { get; }

        public AuthService(
            UserManager<ApplicationUser> userManager,
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IConfiguration configuration)
        {
            this.userManager = userManager;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            Configuration = configuration;
        }

        public async Task<EntityCreatedViewModel> CreateUserAsync(CreateUserDto createUserDto)
        {
            var user = new ApplicationUser
            {
                UserName = createUserDto.Username
            };

            var userResult = await userManager.CreateAsync(user, createUserDto.Password);
            if (!userResult.Succeeded)
            {
                throw new ValidationAppException("User registration failed.", userResult.Errors.Select(ent => ent.Description));
            }
            await unitOfWork.SaveChangesAsync();

            return mapper.Map<EntityCreatedViewModel>(user);
        }

        public async Task<TokenViewModel> LoginAsync(LoginDto loginDto)
        {
            try
            {
                var user = await FindUserAsync(loginDto.Username);
                var passwordMatches = await userManager.CheckPasswordAsync(user, loginDto.Password);
                if (!passwordMatches)
                {
                    throw new Exception();
                }
                return new TokenViewModel
                {
                    AccessToken = CreateAccessToken(user)
                };
            }
            catch (Exception)
            {
                throw new ValidationAppException("Login attempt failed.", new[]
                {
                    "Invalid user credentials."
                });
            }
        }

        private async Task<ApplicationUser> FindUserAsync(string username)
        {
            var user = await userManager.FindByNameAsync(username);
            if (user == null)
            {
                throw new EntityNotFoundException($"User with username '{username}' not found.");
            }
            return user;
        }

        private string CreateAccessToken(ApplicationUser user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:SigningKey"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddMinutes(Convert.ToDouble(Configuration["Jwt:ExpirationMinutes"]));

            var token = new JwtSecurityToken(
                Configuration["Jwt:Issuer"],
                Configuration["Jwt:Audience"],
                claims,
                expires: expires,
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}