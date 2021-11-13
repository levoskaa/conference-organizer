using Domain.Entitites.Abstractions;
using Domain.Exceptions;
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

        public void Update(Conference updatedConference)
        {
            Name = updatedConference.Name;
            TimeFrame = updatedConference.TimeFrame;
        }

        public void AddSection(Section section)
        {
            foreach (var s in Sections)
            {
                if (s.RoomId.Equals(section.RoomId) && (s.TimeFrame.BeginDate <= section.TimeFrame.EndDate && s.TimeFrame.EndDate <= section.TimeFrame.BeginDate))
                {
                    throw new DomainException("A section in the same room with overlapping time frame exists.");
                }
            }

            sections.Add(section);
        }

        public bool DeleteSection(Section section)
        {
            return sections.Remove(section);
        }

        public void AddUserConference(ApplicationUserConference userConference)
        {
            userConferences.Add(userConference);
        }
    }
}