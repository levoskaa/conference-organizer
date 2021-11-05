using System;
using System.Collections.Generic;

namespace BLL.Dtos
{
    public class ConferenceUpsertDto
    {
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<int> ApplicationUsers { get; set; }
    }
}