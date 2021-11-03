using Domain.Entitites.Abstractions;
using System.Collections.Generic;

namespace Domain.Entitites
{
    public class Room : EntityBase
    {
        public string UniqueName { get; set; }
        public int Capacity { get; set; }

        private readonly List<Section> sections;
        public IReadOnlyCollection<Section> Sections => sections;

        public Room()
        {
            sections = new List<Section>();
        }
    }
}