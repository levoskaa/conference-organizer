using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class SectionEntityTypeConfiguration : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> sectionConfiguration)
        {
            sectionConfiguration.ToTable("Sections");

            sectionConfiguration.HasKey(s => s.Id);

            sectionConfiguration.Property(s => s.Id)
                .UseHiLo("sectionseq");

            // TimeFrame value object persisted as owned entity
            sectionConfiguration.OwnsOne(s => s.TimeFrame, t =>
            {
                t.Property<int>("SectionId").UseHiLo("sectionseq");
                t.WithOwner();
                t.Property(t => t.BeginDate).HasColumnName("BeginDate");
                t.Property(t => t.EndDate).HasColumnName("EndDate");
            });

            sectionConfiguration.HasOne(s => s.Conference)
                .WithMany(nameof(Conference.Sections))
                .HasForeignKey(nameof(Section.ConferenceId))
                .OnDelete(DeleteBehavior.Cascade);

            sectionConfiguration.HasOne(s => s.Room)
                .WithMany(nameof(Room.Sections))
                .HasForeignKey(nameof(Section.RoomId));

            sectionConfiguration.HasOne(s => s.User)
                .WithMany(nameof(ApplicationUser.ModeratedSections))
                .HasForeignKey(nameof(Section.UserId));

            sectionConfiguration.HasOne(s => s.Field)
                .WithMany(nameof(ProfessionalField.SectionsAboutField))
                .HasForeignKey(nameof(Section.FieldId));
        }
    }
}