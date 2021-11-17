using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace BLL.Dtos
{
    public class PresentationUpsertDto
    {
        [Index(0)]
        public string Presenter { get; set; }

        [Index(1)]
        public string Title { get; set; }
    }
}
