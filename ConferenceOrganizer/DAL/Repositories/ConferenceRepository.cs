using Domain.Entitites;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ConferenceRepository : IConferenceRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ConferenceRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Conference>> GetConferencesAsync()
        {
            var conferences = await dbContext.Conferences.ToListAsync();
            return conferences;
        }
    }
}