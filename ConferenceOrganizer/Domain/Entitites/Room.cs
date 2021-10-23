using Domain.Entitites.Abstractions;
using System.Collections.Generic;

namespace Domain.Entitites
{
    public class Room : EntityBase
    {
        public string UniqueName { get; set; }
        public int Capacity { get; set; }
        public List<Section> Sections { get; set; }
    }
}