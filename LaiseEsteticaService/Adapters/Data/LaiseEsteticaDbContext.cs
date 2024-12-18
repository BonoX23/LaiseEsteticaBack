using Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Domain.Customer.Entities;
using Domain.PathologicalHistory.Entities;
using Domain.ProfessionalEvaluation.Entities;
using Domain.SocialHistory.Entities;
using Domain.AestheticHistory.Entities;
using System.Linq.Expressions;
using Domain.Utils;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data
{
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

            ConfigureEntityWithOneToOneRelationship<SocialHistory>(modelBuilder);
            ConfigureEntityWithOneToOneRelationship<PathologicalHistory>(modelBuilder);
            ConfigureEntityWithOneToOneRelationship<AestheticHistory>(modelBuilder);
            ConfigureEntityWithOneToOneRelationship<ProfessionalEvaluation>(modelBuilder);

            ConfigurePathologicalHistory(modelBuilder);
            ConfigureProfessionalEvaluation(modelBuilder);
        }

        private void ConfigureCustomerRelationships(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(customer =>
            {
                customer.HasKey(e => e.Id);

                customer.HasOne(e => e.User)
                    .WithMany()
                    .HasForeignKey(e => e.UserId);

                ConfigureOneToOneRelationship(customer, e => e.SocialHistory);
                ConfigureOneToOneRelationship(customer, e => e.PathologicalHistory);
                ConfigureOneToOneRelationship(customer, e => e.AestheticHistory);
                ConfigureOneToOneRelationship(customer, e => e.ProfessionalEvaluation);
            });
        }

        private void ConfigureOneToOneRelationship<TEntity>(
            EntityTypeBuilder<Customer> builder,
            Expression<Func<Customer, TEntity>> navigationExpression)
            where TEntity : class, ICustomerEntity
        {
            builder.HasOne(navigationExpression)
                .WithOne()
                .HasForeignKey<TEntity>(e => e.CustomerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }

        private void ConfigureEntityWithOneToOneRelationship<TEntity>(ModelBuilder modelBuilder) where TEntity : class, ICustomerEntity
        {
            modelBuilder.Entity<TEntity>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne<Customer>()
                    .WithOne()
                    .HasForeignKey<TEntity>(e => e.CustomerId)
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

        private void ConfigureProfessionalEvaluation(ModelBuilder modelBuilder)
        {
            var professionalEvaluationEntity = modelBuilder.Entity<ProfessionalEvaluation>();

            professionalEvaluationEntity.OwnsOne(pe => pe.Hypotonia);

            professionalEvaluationEntity
                .HasMany(pe => pe.Fegs)
                .WithOne()
                .HasForeignKey(f => f.ProfessionalEvaluationId);

            professionalEvaluationEntity
                .HasMany(pe => pe.Adiposities)
                .WithOne()
                .HasForeignKey(a => a.ProfessionalEvaluationId);

            professionalEvaluationEntity
                .HasMany(pe => pe.StretchMarks)
                .WithOne()
                .HasForeignKey(sm => sm.ProfessionalEvaluationId);

            professionalEvaluationEntity
                .HasMany(pe => pe.BiometricControls)
                .WithOne()
                .HasForeignKey(bc => bc.ProfessionalEvaluationId);

            professionalEvaluationEntity
                .HasMany(pe => pe.Protocols)
                .WithOne()
                .HasForeignKey(p => p.ProfessionalEvaluationId);
        }
    }
}