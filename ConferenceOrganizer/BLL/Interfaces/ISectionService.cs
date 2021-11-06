using BLL.ViewModels;
using System.Threading.Tasks;
using BLL.Dtos;

namespace BLL.Interfaces
{
    public interface ISectionService
    {
        Task<SectionViewModel> FindSectionByIdAsync(int sectionId);

        Task AddPresentationsAsync(int sectionId, PresentationsUpsertDto presentationsUpsertDto);
    }
}