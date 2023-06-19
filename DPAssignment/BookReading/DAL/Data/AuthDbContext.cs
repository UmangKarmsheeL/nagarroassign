using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            

            var adminRoleId = "a9d0e6df-8198-4191-a723-8084d4ed8f19";
            var userRoleId = "6e335696-3ba0-4264-b1d2-b489a743fd11";
            var superAdminRoleId = "7401f78c-40fb-4aed-a949-179947a05782";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Name= "Admin",
                    NormalizedName="Admin",
                    Id=adminRoleId,
                    ConcurrencyStamp=adminRoleId
                },
                new IdentityRole
                {
                    Name= "superAdmin",
                    NormalizedName="superAdmin",
                    Id=superAdminRoleId,
                    ConcurrencyStamp=superAdminRoleId
                },
                new IdentityRole
                {
                    Name= "User",
                    NormalizedName="User",
                    Id=userRoleId,
                    ConcurrencyStamp=userRoleId
                }
            };


            builder.Entity<IdentityRole>().HasData(roles);


            //Seed S-Admin

            var superAdminId = "88f892b9-8c00-4edf-8e9d-aa7c2f211d83";
            var superAdminUser = new IdentityUser
            {
                UserName = "umang@nagarro.com",
                Email = "umang@nagarro.com",
                NormalizedEmail = "umang@nagarro.com".ToUpper(),
                NormalizedUserName = "umang@nagarro.com".ToUpper(),
                Id = superAdminId
            };
            superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(superAdminUser, "Nagarro@123");

            builder.Entity<IdentityUser>().HasData(superAdminUser);


            //Add roles of S-Admin

            var superAdminRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    RoleId=adminRoleId,
                    UserId= superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId= userRoleId,
                    UserId= superAdminId
                },
                new IdentityUserRole<string>
                {
                    RoleId=superAdminRoleId,
                    UserId= superAdminId
                },
            };
            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);

            builder.Entity<IdentityUser>().HasIndex(u => u.Email).IsUnique();
            builder.Entity<IdentityUser>().HasIndex(u => u.UserName).IsUnique();
        }
    }
}
