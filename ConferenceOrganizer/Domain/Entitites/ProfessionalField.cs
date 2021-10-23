using Domain.Entitites.Abstractions;
using System.Collections.Generic;

namespace Domain.Entitites
{
    public class ProfessionalField : EntityBase
    {
        public string Name { get; set; }
        public List<ApplicationUserProfessionalField> UserFields { get; set; }
    }
}