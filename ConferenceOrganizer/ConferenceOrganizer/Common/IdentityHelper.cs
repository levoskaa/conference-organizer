using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Web.Common
{
    public class IdentityHelper
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public IdentityHelper(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public int GetAuthenticatedUserId()
        {
            return int.Parse(httpContextAccessor.HttpContext.User.FindFirstValue(JwtRegisteredClaimNames.Sub));
        }
    }
}