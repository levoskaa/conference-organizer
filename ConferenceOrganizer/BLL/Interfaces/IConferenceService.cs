using BLL.Dtos;
using BLL.ViewModels;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IConferenceService
    {
        Task<EntityCreatedViewModel> CreateConferenceAsync(ConferenceUpsertDto conferenceCreatetDto);

        Task<ConferencesViewModel> GetAllConferencesAsync();

        Task<ConferenceViewModel> FindConferenceByIdAsync(int conferenceId);

        Task UpdateConferenceAsync(int conferenceId, ConferenceUpsertDto conferenceUpdateDto);

        Task DeleteConferenceAsync(int conferenceId);

        Task<SectionsViewModel> GetAllConferenceSectionsAsync(int conferenceId);

        Task DeleteSectionAsync(int conferenceId, int sectionId);

        Task<EntityCreatedViewModel> AddSectionAsync(int conferenceId, SectionUpsertDto sectionCreateDto);
    }
}