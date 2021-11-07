using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Dtos
{
    public class RoomUpsertDto
    {
        public string UniqueName { get; set; }
        public int Capacity { get; set; }
    }
}
