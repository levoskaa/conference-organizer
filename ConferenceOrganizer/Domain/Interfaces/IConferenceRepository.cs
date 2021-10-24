using Domain.Entitites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IConferenceRepository
    {
        Task<IEnumerable<Conference>> GetConferencesAsync();
    }
}