using Domain.Entitites.Abstractions;
using Domain.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Entitites
{
    public class Section : EntityBase
    {
        public TimeFrame TimeFrame { get; set; }
        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int ChairmanId { get; set; }
        public ApplicationUser Chairman { get; private set; }
        public int FieldId { get; set; }
        public ProfessionalField Field { get; private set; }

        private readonly List<Presentation> presentations;
        public IReadOnlyCollection<Presentation> Presentations => presentations;

        public Section()
        {
            presentations = new List<Presentation>();
        }

        public void AddPresentation(Presentation presentation)
        {
            presentations.Add(presentation);
        }

        public void UpdateChairmanAndField(ApplicationUser chairman, ProfessionalField field)
        {
            if (!chairman.GetFields().Contains(field))
            {
                throw new DomainException($"Chairman is not an expert of {field.Name}.");
            }
            Chairman = chairman;
            Field = field;
        }
    }
}