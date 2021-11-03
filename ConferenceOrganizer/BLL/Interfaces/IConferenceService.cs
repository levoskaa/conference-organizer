using BLL.ViewModels;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IConferenceService
    {
        Task<ConferencesViewModel> GetAllConferencesAsync();

        Task<ConferenceViewModel> FindConferenceByIdAsync(int conferenceId);
    }
}