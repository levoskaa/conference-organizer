using Domain.Entitites;
using Domain.Exceptions;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class SectionRepository : ISectionRepository
    {
        private readonly ApplicationDbContext dbContext;

        public SectionRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Section> FindSectionByIdAsync(int sectionId)
        {
            var section = await dbContext.Sections
                .Include(s => s.Room)
                .Include(s => s.Chairman)
                .Include(s => s.Field)
                .FirstOrDefaultAsync(s => s.Id == sectionId);
            if (section == null)
            {
                throw new EntityNotFoundException($"Section with id {sectionId} not found.");
            }
            return section;
        }

        public async Task DeleteSectionAsync(int sectionId)
        {
            var section = await dbContext.Sections.FindAsync(sectionId);
            if (section != null)
            {
                dbContext.Sections.Remove(section);
            }
        }
    }
}