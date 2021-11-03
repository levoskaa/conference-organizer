using System;

namespace BLL.ViewModels
{
    public class SectionViewModel
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Room { get; set; }
        public string Chairman { get; set; }
        public string Field { get; set; }
    }
}