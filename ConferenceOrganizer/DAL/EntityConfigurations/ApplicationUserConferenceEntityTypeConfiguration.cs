using Domain.Entitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfigurations
{
    internal class ApplicationUserConferenceEntityTypeConfiguration : IEntityTypeConfiguration<ApplicationUserConference>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserConference> builder)
        {
            builder.ToTable("UserConference");

            // Create composite key
            builder.HasKey(uc => new { uc.UserId, uc.ConferenceId });

            builder.HasOne(uc => uc.User)
                .WithMany(nameof(ApplicationUser.UserConferences))
                .HasForeignKey(nameof(ApplicationUserConference.UserId))
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(uc => uc.Conference)
                .WithMany(nameof(Conference.UserConferences))
                .HasForeignKey(nameof(ApplicationUserConference.ConferenceId))
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}