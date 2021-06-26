using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeYonetim.MvcWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUser>(m => m.ToTable("Users"));
            modelBuilder.Entity<IdentityRole>(m => m.ToTable("Roles"));
            modelBuilder.Entity<IdentityUserRole<string>>(m => m.ToTable("UserRoles"));
            modelBuilder.Entity<IdentityRoleClaim<string>>(m => m.ToTable("RoleClaims"));
            modelBuilder.Entity<IdentityUserClaim<string>>(m => m.ToTable("UserClaims"));
            modelBuilder.Entity<IdentityUserLogin<string>>(m => m.ToTable("UserLogins"));
            modelBuilder.Entity<IdentityUserToken<string>>(m => m.ToTable("UserTokens"));
        }
    }
}
