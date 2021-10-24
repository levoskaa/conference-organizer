﻿using BLL.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Common;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class ConferenceController : ApiController
    {
        private readonly IConferenceService conferenceService;

        public ConferenceController(IConferenceService conferenceService)
        {
            this.conferenceService = conferenceService;
        }

        [HttpGet]
        public async Task<ConferencesViewModel> GetConferences()
        {
            return new ConferencesViewModel
            {
                Conferences = await conferenceService.GetConferencesAsync()
            };
        }
    }
}