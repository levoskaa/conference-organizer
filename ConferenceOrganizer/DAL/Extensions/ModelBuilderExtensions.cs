using Domain.Entitites;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace DAL.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Users

            var users = new List<ApplicationUser>();
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            var admin = new ApplicationUser
            {
                Id = 1,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            admin.PasswordHash = passwordHasher.HashPassword(admin, "abc123");
            users.Add(admin);

            for (int i = 2; i <= 20; i++)
            {
                var user = new ApplicationUser
                {
                    Id = i,
                    UserName = $"user{i}",
                    NormalizedUserName = $"USER{i}",
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                user.PasswordHash = passwordHasher.HashPassword(user, "abc123");
                users.Add(user);
            }
            modelBuilder.Entity<ApplicationUser>()
                    .HasData(users);

            #endregion Users

            #region Roles

            modelBuilder.Entity<ApplicationRole>()
                .HasData(new ApplicationRole
                {
                    Id = 1,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });

            modelBuilder.Entity<IdentityUserRole<int>>()
                .HasData(new IdentityUserRole<int>
                {
                    RoleId = 1,
                    UserId = 1
                });

            #endregion Roles

            #region Fields

            var field1 = new ProfessionalField("Physics")
            {
                Id = 1,
            };
            var field2 = new ProfessionalField("Medicine")
            {
                Id = 2,
            };
            var field3 = new ProfessionalField("Sociology")
            {
                Id = 3,
            };
            var field4 = new ProfessionalField("Information Technology")
            {
                Id = 4,
            };
            var field5 = new ProfessionalField("Economics")
            {
                Id = 5,
            };
            modelBuilder.Entity<ProfessionalField>()
                .HasData(
                    field1,
                    field2,
                    field3,
                    field4,
                    field5
                );

            #endregion Fields

            #region UserProfessionalField

            modelBuilder.Entity<ApplicationUserProfessionalField>()
                .HasData(
                    new ApplicationUserProfessionalField { UserId = 2, FieldId = 3 },
                    new ApplicationUserProfessionalField { UserId = 3, FieldId = 4 },
                    new ApplicationUserProfessionalField { UserId = 4, FieldId = 3 },
                    new ApplicationUserProfessionalField { UserId = 4, FieldId = 5 },
                    new ApplicationUserProfessionalField { UserId = 5, FieldId = 1 },
                    new ApplicationUserProfessionalField { UserId = 5, FieldId = 4 },
                    new ApplicationUserProfessionalField { UserId = 6, FieldId = 3 },
                    new ApplicationUserProfessionalField { UserId = 7, FieldId = 4 },
                    new ApplicationUserProfessionalField { UserId = 7, FieldId = 5 },
                    new ApplicationUserProfessionalField { UserId = 8, FieldId = 1 },
                    new ApplicationUserProfessionalField { UserId = 9, FieldId = 2 },
                    new ApplicationUserProfessionalField { UserId = 9, FieldId = 3 },
                    new ApplicationUserProfessionalField { UserId = 10, FieldId = 1 },
                    new ApplicationUserProfessionalField { UserId = 11, FieldId = 4 },
                    new ApplicationUserProfessionalField { UserId = 12, FieldId = 1 },
                    new ApplicationUserProfessionalField { UserId = 13, FieldId = 2 },
                    new ApplicationUserProfessionalField { UserId = 13, FieldId = 3 },
                    new ApplicationUserProfessionalField { UserId = 13, FieldId = 4 },
                    new ApplicationUserProfessionalField { UserId = 14, FieldId = 3 },
                    new ApplicationUserProfessionalField { UserId = 15, FieldId = 5 },
                    new ApplicationUserProfessionalField { UserId = 16, FieldId = 1 },
                    new ApplicationUserProfessionalField { UserId = 16, FieldId = 4 },
                    new ApplicationUserProfessionalField { UserId = 17, FieldId = 3 },
                    new ApplicationUserProfessionalField { UserId = 18, FieldId = 4 },
                    new ApplicationUserProfessionalField { UserId = 18, FieldId = 5 },
                    new ApplicationUserProfessionalField { UserId = 19, FieldId = 1 },
                    new ApplicationUserProfessionalField { UserId = 20, FieldId = 2 },
                    new ApplicationUserProfessionalField { UserId = 20, FieldId = 3 }
                );

            #endregion UserProfessionalField

            #region Rooms

            for (int i = 1; i <= 10; i++)
            {
                var room = new Room("A1", 100);
            }
            var room1 = new Room("A1", 100)
            {
                Id = 1,
            };
            var room2 = new Room("A2", 150)
            {
                Id = 2,
            };
            var room3 = new Room("A3", 80)
            {
                Id = 3,
            };
            var room4 = new Room("A4", 60)
            {
                Id = 4,
            };
            var room5 = new Room("A5", 75)
            {
                Id = 5,
            };
            var room6 = new Room("B1", 30)
            {
                Id = 6,
            };
            var room7 = new Room("B2", 130)
            {
                Id = 7,
            };
            var room8 = new Room("B3", 50)
            {
                Id = 8,
            };
            var room9 = new Room("B4", 100)
            {
                Id = 9,
            };
            var room10 = new Room("B5", 75)
            {
                Id = 10,
            };
            modelBuilder.Entity<Room>()
                .HasData(
                    room1,
                    room2,
                    room3,
                    room4,
                    room5,
                    room6,
                    room7,
                    room8,
                    room9,
                    room10
                );

            #endregion Rooms

            #region Conferences

            var conference1 = new Conference
            {
                Id = 1,
                Name = "Conference 1",
            };
            var confererence2 = new Conference
            {
                Id = 2,
                Name = "Conference 2",
            };
            modelBuilder.Entity<Conference>()
                .HasData(new[] {
                    conference1,
                    confererence2,
                });
            modelBuilder.Entity<Conference>()
                .OwnsOne(c => c.TimeFrame)
                .HasData(
                    new { ConferenceId = 1, BeginDate = new DateTime(2021, 12, 7, 8, 0, 0), EndDate = new DateTime(2021, 12, 07, 12, 0, 0) },
                    new { ConferenceId = 2, BeginDate = new DateTime(2022, 1, 12, 10, 0, 0), EndDate = new DateTime(2022, 1, 12, 16, 0, 0) }
                );

            #endregion Conferences

            #region UserConference

            modelBuilder.Entity<ApplicationUserConference>()
                .HasData(
                    new ApplicationUserConference { UserId = 2, ConferenceId = 1 },
                    new ApplicationUserConference { UserId = 3, ConferenceId = 1 },
                    new ApplicationUserConference { UserId = 4, ConferenceId = 1 },
                    new ApplicationUserConference { UserId = 5, ConferenceId = 1 },
                    new ApplicationUserConference { UserId = 6, ConferenceId = 2 },
                    new ApplicationUserConference { UserId = 7, ConferenceId = 2 },
                    new ApplicationUserConference { UserId = 8, ConferenceId = 2 },
                    new ApplicationUserConference { UserId = 9, ConferenceId = 2 }
                );

            #endregion UserConference

            #region Sections

            // Conference1 sections
            var section1 = new Section
            {
                Id = 1,
                ConferenceId = 1,
                RoomId = 3,
                ChairmanId = 2,
                FieldId = 3,
            };
            var section2 = new Section
            {
                Id = 2,
                ConferenceId = 1,
                RoomId = 3,
                ChairmanId = 10,
                FieldId = 1,
            };

            // Conference2 sections
            var section3 = new Section
            {
                Id = 3,
                ConferenceId = 2,
                RoomId = 5,
                ChairmanId = 16,
                FieldId = 4,
            };
            var section4 = new Section
            {
                Id = 4,
                ConferenceId = 2,
                RoomId = 1,
                ChairmanId = 7,
                FieldId = 5,
            };
            var section5 = new Section
            {
                Id = 5,
                ConferenceId = 2,
                RoomId = 1,
                ChairmanId = 10,
                FieldId = 1,
            };

            modelBuilder.Entity<Section>()
                .HasData(new[] {
                    section1,
                    section2,
                    section3,
                    section4,
                    section5,
                });

            modelBuilder.Entity<Section>()
                .OwnsOne(s => s.TimeFrame)
                .HasData(
                    new { SectionId = 1, BeginDate = new DateTime(2021, 12, 7, 8, 0, 0), EndDate = new DateTime(2021, 12, 07, 10, 0, 0) },
                    new { SectionId = 2, BeginDate = new DateTime(2021, 12, 7, 10, 0, 0), EndDate = new DateTime(2021, 12, 07, 12, 0, 0) },
                    new { SectionId = 3, BeginDate = new DateTime(2022, 1, 12, 10, 0, 0), EndDate = new DateTime(2022, 1, 12, 12, 30, 0) },
                    new { SectionId = 4, BeginDate = new DateTime(2022, 1, 12, 12, 30, 0), EndDate = new DateTime(2022, 1, 12, 15, 0, 0) },
                    new { SectionId = 5, BeginDate = new DateTime(2022, 1, 12, 15, 0, 0), EndDate = new DateTime(2022, 1, 12, 16, 0, 0) }
                );

            #endregion Sections

            #region Presentations

            var firstnames = new string[] { "Levente", "Géza", "Máté", "Sára", "Anna", "Bernadett" };
            var lastnames = new string[] { "Kovács", "Kiss", "Fehér", "Erőss", "Németh", "Herczeg" };

            var presentations = new List<Presentation>();
            for (int i = 1; i < 14; i++)
            {
                var rnd = new Random();
                var presenter = lastnames[rnd.Next(6)] + firstnames[rnd.Next(6)];
                var presentation = new Presentation(presenter, $"Presentation {i}")
                {
                    Id = i,
                    SectionId = (i % 4) + 1,
                };
                presentations.Add(presentation);
            }

            modelBuilder.Entity<Presentation>()
                    .HasData(presentations);

            #endregion Presentations
        }
    }
}