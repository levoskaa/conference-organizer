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

        public async Task<IEnumerable<ConferenceViewModel>> GetConferencesAsync()
        {
            var conferences = await conferenceRepository.GetConferencesAsync();
            var conferenceViewModels = mapper.Map<IEnumerable<ConferenceViewModel>>(conferences);
            return conferenceViewModels;
        }
    }
}