using BLL.Dtos;
using BLL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IConferenceService
    {
        Task<EntityCreatedViewModel> CreateConferenceAsync(ConferenceUpsertDto conferenceCreatetDto);

        Task<ConferencesViewModel> GetAllConferencesAsync();

        Task<ConferenceViewModel> FindConferenceByIdAsync(int conferenceId);

        Task UpdateConferenceAsync(int conferenceId, ConferenceUpsertDto conferenceUpdateDto, IEnumerable<string> userRoles);

        Task DeleteConferenceAsync(int conferenceId);

        Task<SectionsViewModel> GetAllConferenceSectionsAsync(int conferenceId);

        Task<EntityCreatedViewModel> AddSectionAsync(int conferenceId, SectionUpsertDto sectionCreateDto);
    }
}