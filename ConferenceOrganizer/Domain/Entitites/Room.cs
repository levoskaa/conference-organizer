using Domain.Entitites.Abstractions;
using Domain.Exceptions;
using System.Collections.Generic;

namespace Domain.Entitites
{
    public class Room : EntityBase
    {
        public string UniqueName { get; set; }
        private int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value <= 0)
                {
                    throw new DomainException("Room capacity must be greater than 0.");
                }
                capacity = value;
            }
        }

        private readonly List<Section> sections;
        public IReadOnlyCollection<Section> Sections => sections;

        public Room()
        {
            sections = new List<Section>();
        }

        public Room(string name, int capacity)
            : this()
        {
            UniqueName = name;
            Capacity = capacity;
        }
    }
}