using System;
using BLL.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BLL.Dtos;
using BLL.Exceptions;
using Microsoft.AspNetCore.Http;
using Web.Common;
using Microsoft.AspNetCore.Authorization;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class SectionsController : ApiController
    {
        private readonly ISectionService sectionService;

        public SectionsController(ISectionService sectionService)
        {
            this.sectionService = sectionService;
        }

        [HttpPost("{sectionId}/presentations")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public Task AddPresentations([FromRoute] int sectionId, [FromBody] PresentationsUpsertDto presentationsUpsertDto)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status201Created;
            return sectionService.AddPresentationsAsync(sectionId, presentationsUpsertDto);
        }

        [HttpPost("{sectionId}/presentations/file")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public Task AddPresentationsByFile([FromRoute] int sectionId)
        {
          HttpContext.Response.StatusCode = StatusCodes.Status201Created;

          try
          {
            var file = Request.Form.Files[0];
            return sectionService.AddPresentationsByFileAsync(sectionId, file);
          }
          catch (Exception e)
          {
            throw new AppException("No file attached or wrong file format given.");
          }
          

        }

    [HttpGet("{sectionId}")]
        public Task<SectionViewModel> GetSectionById([FromRoute] int sectionId)
        {
            return sectionService.FindSectionByIdAsync(sectionId);
        }

        [HttpPut("{sectionId}")]
        [Authorize]
        public Task UpdatSection([FromRoute] int sectionId, [FromBody] SectionUpsertDto sectionUpdateDto)
        {
            return sectionService.UpdateSectionAsync(sectionId, sectionUpdateDto);
        }

        [HttpDelete("{sectionId}")]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public Task DeleteSection([FromRoute] int sectionId)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status204NoContent;
            return sectionService.DeleteSectionAsync(sectionId);
        }
    }
}