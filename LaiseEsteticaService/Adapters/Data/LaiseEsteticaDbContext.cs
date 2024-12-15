using Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domain.Customer.Entities;
using Domain.PathologicalHistory.Entities;
using Domain.ProfessionalEvaluation.Entities;
using Domain.SocialHistory.Entities;
using Domain.AestheticHistory.Entities;

namespace Data;

public class LaiseEsteticaDbContext :
    IdentityDbContext<User, Role, Guid,
    IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>,
    IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
{
    public LaiseEsteticaDbContext(DbContextOptions<LaiseEsteticaDbContext> options)
        : base(options) { }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<SocialHistory> SocialHistories { get; set; }
    public DbSet<PathologicalHistory> PathologicalHistories { get; set; }
    public DbSet<AestheticHistory> AestheticHistories { get; set; }
    public DbSet<ProfessionalEvaluation> ProfessionalEvaluations { get; set; }

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
        });

        ConfigureCustomerRelationships(modelBuilder);
        ConfigurePathologicalHistory(modelBuilder);
    }

    private void ConfigureCustomerRelationships(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(customer =>
        {
            customer.HasKey(e => e.Id);

            customer.HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserId);

            customer.HasOne(e => e.SocialHistory)
                .WithOne(e => e.Customer)
                .HasForeignKey<SocialHistory>(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            customer.HasOne(e => e.PathologicalHistory)
                .WithOne(e => e.Customer)
                .HasForeignKey<PathologicalHistory>(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            customer.HasOne(e => e.AestheticHistory)
                .WithOne(e => e.Customer)
                .HasForeignKey<AestheticHistory>(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            customer.HasOne(e => e.ProfessionalEvaluation)
                .WithOne(e => e.Customer)
                .HasForeignKey<ProfessionalEvaluation>(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<SocialHistory>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(e => e.Customer)
                .WithOne(c => c.SocialHistory)
                .HasForeignKey<SocialHistory>(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<PathologicalHistory>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(e => e.Customer)
                .WithOne(c => c.PathologicalHistory)
                .HasForeignKey<PathologicalHistory>(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<AestheticHistory>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(e => e.Customer)
                .WithOne(c => c.AestheticHistory)
                .HasForeignKey<AestheticHistory>(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<ProfessionalEvaluation>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.HasOne(e => e.Customer)
                .WithOne(c => c.ProfessionalEvaluation)
                .HasForeignKey<ProfessionalEvaluation>(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        });
    }

    private void ConfigurePathologicalHistory(ModelBuilder modelBuilder)
    {
        var pathologicalHistoryEntity = modelBuilder.Entity<PathologicalHistory>();

        pathologicalHistoryEntity.OwnsOne(ph => ph.Surgery);
        pathologicalHistoryEntity.OwnsOne(ph => ph.MedicalTreatment);
        pathologicalHistoryEntity.OwnsOne(ph => ph.Medication);
        pathologicalHistoryEntity.OwnsOne(ph => ph.MedicationAllergy);
        pathologicalHistoryEntity.OwnsOne(ph => ph.MenstrualCycle);
        pathologicalHistoryEntity.OwnsOne(ph => ph.Contraceptives);
        pathologicalHistoryEntity.OwnsOne(ph => ph.EndocrineProblems);
        pathologicalHistoryEntity.OwnsOne(ph => ph.HeartProblems);
        pathologicalHistoryEntity.OwnsOne(ph => ph.OncologicalProblemDetails);
    }
}
