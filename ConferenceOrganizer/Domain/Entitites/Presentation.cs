using Domain.Entitites.Abstractions;

namespace Domain.Entitites
{
    public class Presentation : EntityBase
    {
        public string Presenter { get; set; }
        public string Title { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }

        public Presentation()
        {
        }

        public Presentation(string presenter, string title)
        {
            Presenter = presenter;
            Title = title;
        }
    }
}