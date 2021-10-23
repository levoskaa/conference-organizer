using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class PresentationEntityTypeConfiguration : IEntityTypeConfiguration<Presentation>
    {
        public void Configure(EntityTypeBuilder<Presentation> presentationConfiguration)
        {
            presentationConfiguration.ToTable("Presentations");

            presentationConfiguration.HasKey(p => p.Id);

            presentationConfiguration.Property(p => p.Id)
                .UseHiLo("presentationseq");

            presentationConfiguration.HasOne(p => p.Section)
                .WithMany(nameof(Section.Presentations))
                .HasForeignKey(nameof(Presentation.SectionId))
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}