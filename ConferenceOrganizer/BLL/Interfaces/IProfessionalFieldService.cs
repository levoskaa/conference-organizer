using System.Threading.Tasks;
using BLL.Dtos;
using BLL.ViewModels;

namespace BLL.Interfaces
{
    public interface IProfessionalFieldService
    {
        Task<EntityCreatedViewModel> CreateProfessionalFieldAsync(ProfessionalFieldUpsertDto professionalFieldCreatedDto);

        Task<ProfessionalFieldsViewModel> GetAllProfessionalFieldsAsync();

        Task<ProfessionalFieldViewModel> FindProfessionalFieldByIdAsync(int professionalFieldId);

        Task UpdateProfessionalFieldAsync(int professionalFieldId, ProfessionalFieldUpsertDto professionalFieldUpdateDto);

        Task DeleteProfessionalFieldAsync(int professionalFieldId);
    }

}
