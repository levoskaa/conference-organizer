using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    public class ApplicationUserProfessionalFieldEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUserProfessionalField>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserProfessionalField> builder)
        {
            builder.ToTable("UserProfessionalField");

            // Create composite key
            builder.HasKey(uf => new { uf.UserId, uf.FieldId });

            builder.HasOne(uf => uf.User)
                .WithMany(nameof(ApplicationUser.UserFields))
                .HasForeignKey(nameof(ApplicationUserProfessionalField.UserId))
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(uf => uf.Field)
                .WithMany(nameof(ProfessionalField.UserFields))
                .HasForeignKey(nameof(ApplicationUserProfessionalField.FieldId))
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}