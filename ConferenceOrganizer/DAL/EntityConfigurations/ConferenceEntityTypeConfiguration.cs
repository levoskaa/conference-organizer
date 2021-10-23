using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class ConferenceEntityTypeConfiguration : IEntityTypeConfiguration<Conference>
    {
        public void Configure(EntityTypeBuilder<Conference> conferenceConfiguration)
        {
            conferenceConfiguration.ToTable("Conferences");

            conferenceConfiguration.HasKey(c => c.Id);

            conferenceConfiguration.Property(c => c.Id)
                .UseHiLo("conferenceseq");

            // TimeFrame value object persisted as owned entity
            conferenceConfiguration.OwnsOne(c => c.TimeFrame, t =>
            {
                t.Property<int>("ConferenceId").UseHiLo("conferenceseq");
                t.WithOwner();
                t.Property(t => t.BeginDate).HasColumnName("BeginDate");
                t.Property(t => t.EndDate).HasColumnName("EndDate");
            });
        }
    }
}