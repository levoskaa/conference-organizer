using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entitites
{
    public class ApplicationUser : IdentityUser<int>
    {
        private readonly List<ApplicationUserProfessionalField> userFields;
        public IReadOnlyCollection<ApplicationUserProfessionalField> UserFields => userFields;

        private readonly List<ApplicationUserConference> userConferences;
        public IReadOnlyCollection<ApplicationUserConference> UserConferences => userConferences;

        private readonly List<Section> moderatedSections;
        public IReadOnlyCollection<Section> ModeratedSections => moderatedSections;

        public ApplicationUser()
        {
            userFields = new List<ApplicationUserProfessionalField>();
            userConferences = new List<ApplicationUserConference>();
            moderatedSections = new List<Section>();
        }

        public IReadOnlyCollection<ProfessionalField> GetFields()
        {
            return UserFields.Select(uf => uf.Field).ToList();
        }
    }
}