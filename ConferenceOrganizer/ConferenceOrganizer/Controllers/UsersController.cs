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
        private readonly IUserService userService;
        private readonly IIdentityHelper identityHelper;

        public UsersController(
            IAuthService authService,
            IUserService userService,
            IIdentityHelper identityHelper)
        {
            this.authService = authService;
            this.userService = userService;
            this.identityHelper = identityHelper;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public Task<EntityCreatedViewModel> CreateUser([FromBody] CreateUserDto createUserDto)
        {
            HttpContext.Response.StatusCode = (int)HttpStatusCode.Created;
            return authService.CreateUserAsync(createUserDto);
        }

        [HttpGet("me")]
        [Authorize]
        public Task<UserViewModel> GetAuthenticatedUser()
        {
            var userId = identityHelper.GetAuthenticatedUserId();
            return userService.GetUser(userId);
        }

        [HttpPut("me/fields")]
        [Authorize]
        public Task UpdateFields([FromBody] ProfessionalFieldUpdateDto fieldUpdateDto)
        {
            var userId = identityHelper.GetAuthenticatedUserId();
            return userService.UpdateProfessionalFields(userId, fieldUpdateDto);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public Task<UsersViewModel> GetUsers()
        {
          return userService.GetUsers();
        }
  }
}