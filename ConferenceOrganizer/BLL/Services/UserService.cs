using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Enums;
using Domain.Exceptions;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
                .Include(u => u.UserConferences)
                    .ThenInclude(uc => uc.Conference)
                .Include(u => u.UserFields)
                    .ThenInclude(uf => uf.Field)
                .FirstOrDefaultAsync(u => u.Id == id);
            if (user == null)
            {
                throw new EntityNotFoundException($"User with id '{id}' not found.");
            }
            return user;
        }

        public async Task<UserViewModel> GetUser(int userId)
        {
            var user = await FindUserByIdAsync(userId);
            var userRoles = await userManager.GetRolesAsync(user);
            var userViewModel = new UserViewModel
            {
                Username = user.UserName,
                Role = (Role)Enum.Parse(typeof(Role), userRoles.Contains("Admin") ? "Admin" : "User"),
                EditableConferenceIds = user.UserConferences.Select(uc => uc.Conference.Id).ToArray(),
            };
            return userViewModel;
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