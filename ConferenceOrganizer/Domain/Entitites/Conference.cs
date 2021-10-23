using Domain.Entitites.Abstractions;
using System.Collections.Generic;

namespace Domain.Entitites
{
    public class Conference : EntityBase
    {
        public string Name { get; set; }
        public TimeFrame TimeFrame { get; set; }
        public List<ApplicationUserConference> UserConferences { get; set; }
    }
}