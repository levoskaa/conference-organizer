namespace BLL.ViewModels
{
    public class EntityCreatedViewModel
    {
        public int Id { get; set; }

        public EntityCreatedViewModel()
        {
        }

        public EntityCreatedViewModel(int id)
        {
            Id = id;
        }
    }
}