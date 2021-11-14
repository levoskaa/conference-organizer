using BLL.Dtos;
using BLL.Interfaces;
using Domain.Entitites;
using Domain.Exceptions;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProfessionalFieldRepository fieldRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(
            UserManager<ApplicationUser> userManager,
            IProfessionalFieldRepository fieldRepository,
            IUnitOfWork unitOfWork
            )
        {
            this.userManager = userManager;
            this.fieldRepository = fieldRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<ApplicationUser> FindUserByIdAsync(int id)
        {
            var user = await userManager.Users
                .Include(u => u.UserFields)
                    .ThenInclude(uf => uf.Field)
                .FirstOrDefaultAsync(u => u.Id == id);
            if (user == null)
            {
                throw new EntityNotFoundException($"User with id '{id}' not found.");
            }
            return user;
        }

        public async Task UpdateProfessionalFields(int userId, ProfessionalFieldUpdateDto fieldUpdateDto)
        {
            var user = await FindUserByIdAsync(userId);
            var userFields = new List<ApplicationUserProfessionalField>();
            foreach (var fieldId in fieldUpdateDto.ProfessionalFieldIds)
            {
                var field = await fieldRepository.FindProfessionalFieldByIdAsync(fieldId);
                var userField = new ApplicationUserProfessionalField
                {
                    User = user,
                    Field = field
                };
                userFields.Add(userField);
            }
            user.SetUserFields(userFields);
            await unitOfWork.SaveChangesAsync();
        }
    }
}