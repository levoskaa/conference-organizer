using Domain.Entitites.Abstractions;
using System.Collections.Generic;

namespace Domain.Entitites
{
    public class ProfessionalField : EntityBase
    {
        public string Name { get; set; }

        private readonly List<ApplicationUserProfessionalField> userFields;
        public IReadOnlyCollection<ApplicationUserProfessionalField> UserFields => userFields;

        private readonly List<Section> sectionsAboutField;
        public IReadOnlyCollection<Section> SectionsAboutField => sectionsAboutField;

        public ProfessionalField()
        {
            userFields = new List<ApplicationUserProfessionalField>();
            sectionsAboutField = new List<Section>();
        }

        public ProfessionalField(string name)
            : this()
        {
            Name = name;
        }

        public void Update(ProfessionalField updatedField)
        {
            Name = updatedField.Name;
        }
    }
}