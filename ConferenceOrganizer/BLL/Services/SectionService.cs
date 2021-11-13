using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Interfaces;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository sectionRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public SectionService(
            ISectionRepository sectionRepository,
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            this.sectionRepository = sectionRepository;
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<SectionViewModel> FindSectionByIdAsync(int sectionId)
        {
            var section = await sectionRepository.FindSectionByIdAsync(sectionId);
            var sectionViewModel = mapper.Map<SectionViewModel>(section);
            return sectionViewModel;
        }

        public async Task AddPresentationsAsync(int sectionId, PresentationsUpsertDto presentationsUpsertDto)
        {
            var section = await sectionRepository.FindSectionByIdAsync(sectionId);

            foreach (var presentationUpsertDto in presentationsUpsertDto.Presentations)
            {
                var presentation = mapper.Map<Presentation>(presentationUpsertDto);
                section.AddPresentation(presentation);
            }

            await unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteSectionAsync(int sectionId)
        {
            await sectionRepository.DeleteSectionAsync(sectionId);
            await unitOfWork.SaveChangesAsync();
        }
    }
}