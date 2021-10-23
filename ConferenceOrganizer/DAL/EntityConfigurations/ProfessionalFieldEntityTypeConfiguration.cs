using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class ProfessionalFieldEntityTypeConfiguration : IEntityTypeConfiguration<ProfessionalField>
    {
        public void Configure(EntityTypeBuilder<ProfessionalField> fieldConfiguration)
        {
            fieldConfiguration.ToTable("ProfessionalFields");

            fieldConfiguration.HasKey(f => f.Id);

            fieldConfiguration.Property(f => f.Id)
                .UseHiLo("professionalfieldseq");
        }
    }
}