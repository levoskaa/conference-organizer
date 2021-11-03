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

        public async Task<IEnumerable<Conference>> GetAllConferencesAsync()
        {
            var conferences = await dbContext.Conferences.ToListAsync();
            return conferences;
        }

        public async Task<Conference> FindConferenceByIdAsync(int conferenceId)
        {
            return await dbContext.Conferences.FindAsync(conferenceId);
        }
    }
}