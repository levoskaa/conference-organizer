﻿using BLL.Interfaces;
using BLL.ViewModels;
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

        [HttpGet]
        public async Task<ConferencesViewModel> GetConferences()
        {
            return new ConferencesViewModel
            {
                Conferences = await conferenceService.GetAllConferencesAsync()
            };
        }

        [HttpGet("{conferenceId}")]
        public Task<ConferenceViewModel> GetConferenceById([FromRoute] int conferenceId)
        {
            return conferenceService.FindConferenceByIdAsync(conferenceId);
        }
    }
}