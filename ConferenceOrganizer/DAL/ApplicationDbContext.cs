using DAL.EntityConfigurations;
using Domain.Entitites;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<ProfessionalField> ProfessionalFields { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ConferenceEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new RoomEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SectionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PresentationEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessionalFieldEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserProfessionalFieldEntityTypeConfiguration());
        }
    }
}