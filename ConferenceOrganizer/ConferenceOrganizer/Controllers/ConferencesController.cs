using BLL.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Common;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class ConferencesController : ApiController
    {
        private readonly IConferenceService conferenceService;

        public ConferencesController(IConferenceService conferenceService)
        {
            this.conferenceService = conferenceService;
        }

        [HttpGet]
        public Task<ConferencesViewModel> GetConferences()
        {
            return conferenceService.GetAllConferencesAsync();
        }

        [HttpGet("{conferenceId}")]
        public Task<ConferenceViewModel> GetConferenceById([FromRoute] int conferenceId)
        {
            return conferenceService.FindConferenceByIdAsync(conferenceId);
        }
    }
}