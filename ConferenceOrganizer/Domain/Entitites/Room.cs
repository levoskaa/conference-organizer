using Domain.Entitites.Abstractions;

namespace Domain.Entitites
{
    public class Room : EntityBase
    {
        public string UniqueName { get; set; }
        public int Capacity { get; set; }
    }
}