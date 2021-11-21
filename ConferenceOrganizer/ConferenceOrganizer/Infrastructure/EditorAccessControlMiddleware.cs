using BLL.Exceptions;
using BLL.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Web.Common;

namespace Web.Infrastructure
{
    public class EditorAccessControlMiddleware
    {
        private readonly RequestDelegate next;
        private readonly IIdentityHelper identityHelper;
        private readonly IUserService userService;
        private readonly IConferenceService conferenceService;
        private readonly IWebHostEnvironment env;
        private readonly ILogger<ErrorHandlerMiddleware> logger;

        public EditorAccessControlMiddleware(
            RequestDelegate next,
            IIdentityHelper identityHelper,
            IUserService userService,
            IConferenceService conferenceService,
            IWebHostEnvironment env,
            ILogger<ErrorHandlerMiddleware> logger)
        {
            this.next = next;
            this.identityHelper = identityHelper;
            this.userService = userService;
            this.conferenceService = conferenceService;
            this.env = env;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (!httpContext.User.Claims.Any())
            {
                await next(httpContext);
                return;
            }

            if (httpContext.Request.Method.Equals("GET"))
            {
                await next(httpContext);
                return;
            }

            var regex = new Regex(@"^\/api\/\w[-\w]*\/\d+");
            if (!regex.IsMatch(httpContext.Request.Path))
            {
                await next(httpContext);
                return;
            }

            var userId = identityHelper.GetAuthenticatedUserId();
            var user = await userService.FindUserByIdAsync(userId);
            var editableConferences = user.UserConferences.Select(uc => uc.Conference).ToList();
            var pathParts = httpContext.Request.Path.Value.Split('/');
            if (pathParts.Length < 4)
            {
                await next(httpContext);
                return;
            }

            var controller = pathParts[2];
            var id = int.Parse(pathParts[3]);
            if (controller.Equals("conferences"))
            {
                if (!editableConferences.Select(c => c.Id)
                    .Contains(id))
                {
                    throw new NoAccessException($"No acces to conference with id {id}.");
                }
            }
            else if (controller.Equals("sections"))
            {
                var section = editableConferences.SelectMany(c => c.Sections)
                    .FirstOrDefault(s => s.Id == id);
                if (section == null)
                {
                    throw new NoAccessException($"No acces to section with id {id}.");
                }
            }
            else if (controller.Equals("presentations"))
            {
                var presentation = editableConferences.SelectMany(c => c.Sections)
                    .SelectMany(s => s.Presentations)
                    .FirstOrDefault(p => p.Id == id);
                if (presentation == null)
                {
                    throw new NoAccessException($"No acces to presentation with id {id}.");
                }
            }

            await next(httpContext);
        }
    }
}
