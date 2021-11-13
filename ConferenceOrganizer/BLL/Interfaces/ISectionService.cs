using BLL.Dtos;
using BLL.ViewModels;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ISectionService
    {
        Task<SectionViewModel> FindSectionByIdAsync(int sectionId);

        Task AddPresentationsAsync(int sectionId, PresentationsUpsertDto presentationsUpsertDto);

        Task DeleteSectionAsync(int sectionId);
    }
}