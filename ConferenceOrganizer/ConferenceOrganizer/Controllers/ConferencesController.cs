using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public Task<EntityCreatedViewModel> CreateConference([FromBody] ConferenceUpsertDto conferenceCreateDto)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status201Created;
            return conferenceService.CreateConferenceAsync(conferenceCreateDto);
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

        [HttpGet("{conferenceId}/sections")]
        public Task<SectionsViewModel> GetSections([FromRoute] int conferenceId)
        {
            return conferenceService.GetAllConferenceSectionsAsync(conferenceId);
        }

        [HttpPut("{conferenceId}")]
        [Authorize]
        public Task UpdateConference([FromRoute] int conferenceId, [FromBody] ConferenceUpsertDto conferenceUpdateDto)
        {
            return conferenceService.UpdateConferenceAsync(conferenceId, conferenceUpdateDto);
        }

        [HttpDelete("{conferenceId}")]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public Task DeleteConference([FromRoute] int conferenceId)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status204NoContent;
            return conferenceService.DeleteConferenceAsync(conferenceId);
        }
    }
}