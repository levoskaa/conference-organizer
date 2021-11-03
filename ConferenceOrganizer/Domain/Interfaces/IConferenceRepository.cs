using Domain.Entitites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IConferenceRepository
    {
        int AddConference(Conference conference);

        Task<IEnumerable<Conference>> GetAllConferencesAsync();

        Task<Conference> FindConferenceByIdAsync(int conferenceId);

        void UpdateConference(Conference conference);

        Task DeleteConferenceAsync(int conferenceId);
    }
}