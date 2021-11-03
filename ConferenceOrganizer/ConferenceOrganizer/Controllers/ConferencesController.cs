using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public Task<EntityCreatedViewModel> CreateConference([FromBody] ConferenceUpsertDto conferenceCreateDto)
        {
            throw new NotImplementedException();
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

        [HttpPut("{conferenceId}")]
        [Authorize]
        public Task<ConferenceViewModel> UpdateConference([FromRoute] int conferenceId, [FromBody] ConferenceUpsertDto conferenceUpdateDto)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{conferenceId}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public Task DeleteConference([FromRoute] int conferenceId)
        {
            throw new NotImplementedException();
        }
    }
}