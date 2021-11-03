using AutoMapper;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Interfaces;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository sectionRepository;
        private readonly IMapper mapper;

        public SectionService(
            ISectionRepository sectionRepository,
            IMapper mapper)
        {
            this.sectionRepository = sectionRepository;
            this.mapper = mapper;
        }

        public async Task<SectionViewModel> FindSectionByIdAsync(int sectionId)
        {
            var section = await sectionRepository.FindSectionByIdAsync(sectionId);
            var sectionViewModel = mapper.Map<SectionViewModel>(section);
            return sectionViewModel;
        }
    }
}