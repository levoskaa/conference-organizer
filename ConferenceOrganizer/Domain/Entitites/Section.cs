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
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int FieldId { get; set; }
        public ProfessionalField Field { get; set; }
        public List<Presentation> Presentations { get; set; }
    }
}