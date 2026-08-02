using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using EduCore.Domain.Entities;

namespace EduCore.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>().ToTable("AspNetUsers", "identity");

        builder.Entity<ApplicationRole>().ToTable("AspNetRoles", "identity");

        builder.Entity<IdentityUserRole<int>>().ToTable("AspNetUserRoles", "identity");

        builder.Entity<IdentityUserClaim<int>>().ToTable("AspNetUserClaims", "identity");

        builder.Entity<IdentityUserLogin<int>>().ToTable("AspNetUserLogins", "identity");

        builder.Entity<IdentityRoleClaim<int>>().ToTable("AspNetRoleClaims", "identity");

        builder.Entity<IdentityUserToken<int>>().ToTable("AspNetUserTokens", "identity");

    }
}

