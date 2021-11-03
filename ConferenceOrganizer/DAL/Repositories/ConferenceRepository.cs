using Domain.Entitites;
using Domain.Exceptions;
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

        public int AddConference(Conference conference)
        {
            dbContext.Conferences.Add(conference);
            return conference.Id;
        }

        public async Task<IEnumerable<Conference>> GetAllConferencesAsync()
        {
            var conferences = await dbContext.Conferences.ToListAsync();
            return conferences;
        }

        public async Task<Conference> FindConferenceByIdAsync(int conferenceId)
        {
            var conference = await dbContext.Conferences.FindAsync(conferenceId);
            if (conference == null)
            {
                throw new EntityNotFoundException($"Conference with id {conferenceId} not found.");
            }
            return conference;
        }

        public void UpdateConference(Conference conference)
        {
            dbContext.Conferences.Update(conference);
        }

        public async Task DeleteConferenceAsync(int conferenceId)
        {
            var conference = await dbContext.Conferences.FindAsync(conferenceId);
            if (conference != null)
            {
                dbContext.Conferences.Remove(conference);
            }
        }
    }
}