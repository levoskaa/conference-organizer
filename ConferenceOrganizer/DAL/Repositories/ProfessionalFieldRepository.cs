using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entitites;
using Domain.Exceptions;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ProfessionalFieldRepository : IProfessionalFieldRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProfessionalFieldRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int AddProfessionalField(ProfessionalField professionalField)
        {
            dbContext.ProfessionalFields.Add(professionalField);
            return professionalField.Id;
        }

        public async Task<ProfessionalField> FindProfessionalFieldByIdAsync(int professionalFieldId)
        {
            var professionalField = await dbContext.ProfessionalFields
                .FirstOrDefaultAsync(c => c.Id == professionalFieldId);
            if (professionalField == null)
            {
                throw new EntityNotFoundException($"Professional field with id {professionalFieldId} not found.");
            }
            return professionalField;
        }

        public void UpdateProfessionalField(ProfessionalField professionalField)
        {
            dbContext.ProfessionalFields.Update(professionalField);
        }

        public async Task DeleteProfessionalFieldAsync(int professionalFieldId)
        {
            var professionalField = await dbContext.ProfessionalFields.FindAsync(professionalFieldId);
            if (professionalField != null)
            {
                dbContext.ProfessionalFields.Remove(professionalField);
            }
        }

        public async Task<IEnumerable<ProfessionalField>> GetAllProfessionalFieldsAsync()
        {
            var professionalFields = await dbContext.ProfessionalFields.ToListAsync();
            return professionalFields;
        }
    }
}
