using System;

namespace BLL.ViewModels
{
    public class ConferenceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int[] EditorIds { get; set; }
    }
}