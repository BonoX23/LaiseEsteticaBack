using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domain.Identity;
using Domain.Customer.Entities;
using Domain.PathologicalHistory.Entities;
using Domain.ProfessionalEvaluation.Entities;
using Domain.SocialHistory.Entities;

namespace Data;

public class LaiseEsteticaDbContext :
    IdentityDbContext<User, Role, int,
    IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
    IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    public LaiseEsteticaDbContext(DbContextOptions<LaiseEsteticaDbContext> options)
    : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<PathologicalHistory> PathologicalHistories { get; set; }
    public DbSet<ProfessionalEvaluation> ProfessionalEvaluations { get; set; }
    public DbSet<SocialHistory> SocialHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserRole>(userRole =>
        {
            userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

            userRole.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            userRole.HasOne(ur => ur.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
        }
        );
    }
}
