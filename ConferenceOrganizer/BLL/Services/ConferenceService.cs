using AutoMapper;
using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Entitites;
using Domain.Interfaces;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ConferenceService : IConferenceService
    {
        private readonly IConferenceRepository conferenceRepository;
        private readonly ISectionRepository sectionRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ConferenceService(
            IConferenceRepository conferenceRepository,
            ISectionRepository sectionRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.conferenceRepository = conferenceRepository;
            this.sectionRepository = sectionRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<EntityCreatedViewModel> CreateConferenceAsync(ConferenceUpsertDto conferenceCreateDto)
        {
            var conference = mapper.Map<Conference>(conferenceCreateDto);
            var id = conferenceRepository.AddConference(conference);
            await unitOfWork.SaveChangesAsync();
            return new EntityCreatedViewModel(id);
        }

        public async Task<ConferencesViewModel> GetAllConferencesAsync()
        {
            var conferences = await conferenceRepository.GetAllConferencesAsync();
            var conferencesViewModel = mapper.Map<ConferencesViewModel>(conferences);
            return conferencesViewModel;
        }

        public async Task<ConferenceViewModel> FindConferenceByIdAsync(int conferenceId)
        {
            var conference = await conferenceRepository.FindConferenceByIdAsync(conferenceId);
            var conferenceViewModel = mapper.Map<ConferenceViewModel>(conference);
            return conferenceViewModel;
        }

        public async Task UpdateConferenceAsync(int conferenceId, ConferenceUpsertDto conferenceUpdateDto)
        {
            var conference = mapper.Map<Conference>(conferenceUpdateDto);
            conference.Id = conferenceId;
            conferenceRepository.UpdateConference(conference);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteConferenceAsync(int conferenceId)
        {
            await conferenceRepository.DeleteConferenceAsync(conferenceId);
            await unitOfWork.SaveChangesAsync();
        }

        public async Task<SectionsViewModel> GetAllConferenceSectionsAsync(int conferenceId)
        {
            var conference = await conferenceRepository.FindConferenceByIdAsync(conferenceId);
            var sectionsViewModel = mapper.Map<SectionsViewModel>(conference.Sections);
            return sectionsViewModel;
        }

        public async Task DeleteSectionAsync(int conferenceId, int sectionId)
        {
            await conferenceRepository.DeleteSectionAsync(conferenceId, sectionId);
            await unitOfWork.SaveChangesAsync();
        }


        public async Task<EntityCreatedViewModel> AddSectionAsync(int conferenceId, SectionUpsertDto sectionCreateDto)
        { 
            var section = mapper.Map<Section>(sectionCreateDto);
            var id = conferenceRepository.AddSection(conferenceId, section);

            await unitOfWork.SaveChangesAsync();
            return new EntityCreatedViewModel(id.Result);
        }
    }
}