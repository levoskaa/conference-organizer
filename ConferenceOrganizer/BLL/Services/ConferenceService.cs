using AutoMapper;
using BLL.Interfaces;
using BLL.ViewModels;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ConferenceService : IConferenceService
    {
        private readonly IConferenceRepository conferenceRepository;
        private readonly IMapper mapper;

        public ConferenceService(
            IConferenceRepository conferenceRepository,
            IMapper mapper)
        {
            this.conferenceRepository = conferenceRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<ConferenceViewModel>> GetAllConferencesAsync()
        {
            var conferences = await conferenceRepository.GetAllConferencesAsync();
            var conferenceViewModels = mapper.Map<IEnumerable<ConferenceViewModel>>(conferences);
            return conferenceViewModels;
        }

        public async Task<ConferenceViewModel> FindConferenceByIdAsync(int conferenceId)
        {
            var conference = await conferenceRepository.FindConferenceByIdAsync(conferenceId);
            var conferenceViewModel = mapper.Map<ConferenceViewModel>(conference);
            return conferenceViewModel;
        }
    }
}