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
        }
    }
}