using System;

namespace BLL.ViewModels
{
    public class SectionViewModel
    {
        public int Id { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Room { get; set; }
        public string Chairman { get; set; }
        public string Field { get; set; }
    }
}