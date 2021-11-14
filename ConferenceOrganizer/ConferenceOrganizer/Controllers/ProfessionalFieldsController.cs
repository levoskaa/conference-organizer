using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Web.Common;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class ProfessionalFieldsController : ApiController
    {
        private readonly IProfessionalFieldService professionalFieldService;

        public ProfessionalFieldsController(IProfessionalFieldService professionalFieldService)
        {
            this.professionalFieldService = professionalFieldService;
        }

        [HttpPost]
        [Authorize("Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public Task<EntityCreatedViewModel> CreateProfessionalField([FromBody] ProfessionalFieldUpsertDto professionalFieldCreateDto)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status201Created;
            return professionalFieldService.CreateProfessionalFieldAsync(professionalFieldCreateDto);
        }

        [HttpGet]
        public Task<ProfessionalFieldsViewModel> GetProfessionalFields()
        {
            return professionalFieldService.GetAllProfessionalFieldsAsync();
        }

        [HttpGet("{professionalFieldId}")]
        public Task<ProfessionalFieldViewModel> GetProfessionalFieldById([FromRoute] int professionalFieldId)
        {
            return professionalFieldService.FindProfessionalFieldByIdAsync(professionalFieldId);
        }

        [HttpPut("{professionalFieldId}")]
        [Authorize("Admin")]
        public Task UpdateProfessionalField([FromRoute] int professionalFieldId, [FromBody] ProfessionalFieldUpsertDto professionalFieldUpdateDto)
        {
            return professionalFieldService.UpdateProfessionalFieldAsync(professionalFieldId, professionalFieldUpdateDto);
        }

        [HttpDelete("{professionalFieldId}")]
        [Authorize("Admin")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public Task DeleteProfessionalField([FromRoute] int professionalFieldId)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status204NoContent;
            return professionalFieldService.DeleteProfessionalFieldAsync(professionalFieldId);
        }
    }
}
