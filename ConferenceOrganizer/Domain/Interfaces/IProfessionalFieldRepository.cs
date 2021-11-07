using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entitites;

namespace Domain.Interfaces
{
    public interface IProfessionalFieldRepository
    {
        int AddProfessionalField(ProfessionalField professionalField);

        Task<ProfessionalField> FindProfessionalFieldByIdAsync(int professionalFieldId);

        void UpdateProfessionalField(ProfessionalField professionalField);

        Task DeleteProfessionalFieldAsync(int professionalFieldId);

        Task<IEnumerable<ProfessionalField>> GetAllProfessionalFieldsAsync();
    }
}
