using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class RoomEntityTypeConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> roomConfiguration)
        {
            roomConfiguration.ToTable("Rooms");

            roomConfiguration.HasKey(r => r.Id);

            roomConfiguration.Property(r => r.Id)
                .UseHiLo("roomseq");
        }
    }
}