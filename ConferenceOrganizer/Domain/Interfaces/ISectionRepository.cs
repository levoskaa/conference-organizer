using System.Collections.Generic;
using Domain.Entitites;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISectionRepository
    {
        Task<Section> FindSectionByIdAsync(int sectionId);

        Task AddPresentationsAsync(int sectionId, List<Presentation> presentations);
    } 
}