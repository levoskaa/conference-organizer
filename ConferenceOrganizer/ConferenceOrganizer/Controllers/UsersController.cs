using BLL.Dtos;
using BLL.Interfaces;
using BLL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using Web.Common;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : ApiController
    {
        private readonly IAuthService authService;

        public UsersController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        [Authorize("Admin")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public Task<EntityCreatedViewModel> CreateUser([FromBody] CreateUserDto createUserDto)
        {
            HttpContext.Response.StatusCode = (int)HttpStatusCode.Created;
            return authService.CreateUserAsync(createUserDto);
        }
    }
}