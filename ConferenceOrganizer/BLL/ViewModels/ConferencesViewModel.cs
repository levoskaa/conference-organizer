using System.Collections.Generic;

namespace BLL.ViewModels
{
    public class ConferencesViewModel
    {
        public IEnumerable<ConferenceViewModel> Conferences { get; set; }
    }
}