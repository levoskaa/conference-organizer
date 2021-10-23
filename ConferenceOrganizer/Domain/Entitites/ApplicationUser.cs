using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Domain.Entitites
{
    public class ApplicationUser : IdentityUser<int>
    {
        public List<ApplicationUserProfessionalField> UserFields { get; set; }
    }
}