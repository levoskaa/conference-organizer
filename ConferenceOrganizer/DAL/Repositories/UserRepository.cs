using Domain.Entitites;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersAsync()
        {
            return await dbContext.Users
                .Include(u => u.UserConferences)
                    .ThenInclude(uc => uc.Conference)
                .ToListAsync();
        }
    }
}
