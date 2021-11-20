using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.Dtos
{
    public class ConferenceUpsertDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public List<int> Editors { get; set; }
    }
}