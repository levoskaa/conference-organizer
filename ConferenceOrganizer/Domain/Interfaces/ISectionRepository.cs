using Domain.Entitites;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISectionRepository
    {
        Task<Section> FindSectionByIdAsync(int sectionId);

        Task DeleteSectionAsync(int sectionId);
    }
}