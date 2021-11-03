using BLL.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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
    }
}