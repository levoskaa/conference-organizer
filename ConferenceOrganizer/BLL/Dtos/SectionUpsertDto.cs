using System;

namespace BLL.Dtos
{
    public class SectionUpsertDto
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int RoomId { get; set; }
        public int ChairmanId { get; set; }
        public int FieldId { get; set; }
    }
}
