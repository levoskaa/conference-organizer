using BLL.Dtos;
using BLL.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BLL.Interfaces
{
    public interface ISectionService
    {
        Task<SectionViewModel> FindSectionByIdAsync(int sectionId);

        Task AddPresentationsAsync(int sectionId, PresentationsUpsertDto presentationsUpsertDto);

        Task AddPresentationsByFileAsync(int sectionId, IFormFile presentationsFile);

        Task UpdateSectionAsync(int sectionId, SectionUpsertDto sectionUpdateDto);

        Task DeleteSectionAsync(int sectionId);
    }
}