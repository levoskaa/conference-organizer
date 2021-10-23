using Domain.Entitites.Abstractions;

namespace Domain.Entitites
{
    public class Conference : EntityBase
    {
        public string Name { get; set; }
        public TimeFrame TimeFrame { get; set; }
    }
}