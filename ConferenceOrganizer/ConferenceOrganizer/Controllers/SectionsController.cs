using BLL.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using BLL.Dtos;
using Microsoft.AspNetCore.Http;
using Web.Common;

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

        [HttpGet("{sectionId}")]
        public Task<SectionViewModel> GetSectionById([FromRoute] int sectionId)
        {
            return sectionService.FindSectionByIdAsync(sectionId);
        }

        [HttpPost("{sectionId}/presentations")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public Task AddPresentations([FromRoute] int sectionId, [FromBody] PresentationsUpsertDto presentationsUpsertDto)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status201Created;
            return sectionService.AddPresentationsAsync(sectionId, presentationsUpsertDto);
        }
    }
}