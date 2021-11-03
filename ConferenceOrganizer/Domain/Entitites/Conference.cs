using Domain.Entitites.Abstractions;
using System.Collections.Generic;

namespace Domain.Entitites
{
    public class Conference : EntityBase
    {
        public string Name { get; set; }
        public TimeFrame TimeFrame { get; set; }

        private readonly List<ApplicationUserConference> userConferences;
        public IReadOnlyCollection<ApplicationUserConference> UserConferences => userConferences;

        private readonly List<Section> sections;
        public IReadOnlyCollection<Section> Sections => sections;

        public Conference()
        {
            userConferences = new List<ApplicationUserConference>();
            sections = new List<Section>();
        }
    }
}