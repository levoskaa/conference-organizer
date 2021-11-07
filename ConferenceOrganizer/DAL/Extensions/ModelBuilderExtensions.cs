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
        }
    }
}