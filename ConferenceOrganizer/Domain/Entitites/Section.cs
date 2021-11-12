using Domain.Entitites.Abstractions;
using System.Collections.Generic;

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
        public ApplicationUser Chairman { get; set; }
        public int FieldId { get; set; }
        public ProfessionalField Field { get; set; }

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
    }
}