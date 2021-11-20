using System.Collections.Generic;

namespace BLL.ViewModels
{
    public class DropDownViewModel
    {
        public IEnumerable<DropDownItemViewModel> Items { get; set; }
    }
}