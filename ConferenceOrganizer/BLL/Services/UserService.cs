using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using Domain.Entitites;
using Domain.Exceptions;
using Microsoft.AspNetCore.Identity;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<ApplicationUser> FindUserAsync(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                throw new EntityNotFoundException($"User with id '{id}' not found.");
            }
            return user;
        }
    }
}
