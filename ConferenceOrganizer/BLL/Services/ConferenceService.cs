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
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ConferenceService(
            IConferenceRepository conferenceRepository,
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            this.conferenceRepository = conferenceRepository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
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

        public async Task DeleteConferenceAsync(int conferenceId)
        {
            await conferenceRepository.DeleteConferenceAsync(conferenceId);
            await unitOfWork.SaveChangesAsync();
        }
    }
}