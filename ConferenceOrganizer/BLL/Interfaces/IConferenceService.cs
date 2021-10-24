using BLL.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IConferenceService
    {
        Task<IEnumerable<ConferenceViewModel>> GetConferencesAsync();
    }
}