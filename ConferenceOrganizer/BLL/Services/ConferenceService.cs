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
        private readonly IUserService userService;
        private readonly IConferenceRepository conferenceRepository;
        private readonly IRoomRepository roomRepository;
        private readonly IProfessionalFieldRepository professionalFieldRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ConferenceService(
            IUserService userService,
            IConferenceRepository conferenceRepository,
            IRoomRepository roomRepository,
            IProfessionalFieldRepository professionalFieldRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.userService = userService;
            this.conferenceRepository = conferenceRepository;
            this.roomRepository = roomRepository;
            this.professionalFieldRepository = professionalFieldRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<EntityCreatedViewModel> CreateConferenceAsync(ConferenceUpsertDto conferenceCreateDto)
        {
            var conference = mapper.Map<Conference>(conferenceCreateDto);

            await HandleUserConferences(conferenceCreateDto, conference);

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
            var conference = await conferenceRepository.FindConferenceByIdAsync(conferenceId);
            conference.Update(mapper.Map<Conference>(conferenceUpdateDto));
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

        public async Task<EntityCreatedViewModel> AddSectionAsync(int conferenceId, SectionUpsertDto sectionCreateDto)
        {
            var conference = await conferenceRepository.FindConferenceByIdAsync(conferenceId);
            var section = mapper.Map<Section>(sectionCreateDto);
            var field = await professionalFieldRepository.FindProfessionalFieldByIdAsync(sectionCreateDto.FieldId);
            var chairman = await userService.FindUserAsync(sectionCreateDto.ChairmanId);

            section.Room = await roomRepository.FindRoomByIdAsync(sectionCreateDto.RoomId);
            section.UpdateChairmanAndField(chairman, field);
            conference.AddSection(section);

            await unitOfWork.SaveChangesAsync();
            return new EntityCreatedViewModel(section.Id);
        }

        private async Task HandleUserConferences(ConferenceUpsertDto conferenceCreateDto, Conference conference)
        {
            foreach (int applicationUserId in conferenceCreateDto.Editors)
            {
                var user = await userService.FindUserAsync(applicationUserId);
                var applicationUserConference = new ApplicationUserConference()
                {
                    User = user,
                    Conference = conference
                };
                conference.AddUserConference(applicationUserConference);
            }
        }
    }
}