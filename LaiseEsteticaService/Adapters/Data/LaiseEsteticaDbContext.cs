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

            ConfigureOneToOneRelationships(modelBuilder, c => c.SocialHistory);
            ConfigureOneToOneRelationships(modelBuilder, c => c.PathologicalHistory, ConfigurePathologicalHistoryDetails);
            ConfigureOneToOneRelationships(modelBuilder, c => c.AestheticHistory);
            ConfigureOneToOneRelationships(modelBuilder, c => c.ProfessionalEvaluation, ConfigureProfessionalEvaluationDetails);
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
            Expression<Func<Customer, TEntity>> relatedEntity)
            where TEntity : class, ICustomerEntity
        {
            builder.HasOne(relatedEntity)
                .WithOne(e => e.Customer)
                .HasForeignKey<TEntity>(e => e.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private void ConfigureOneToOneRelationships<TEntity>(
            ModelBuilder modelBuilder, 
            Expression<Func<Customer, TEntity>> relatedEntity, 
            Action<EntityTypeBuilder<TEntity>> additionalConfig = null)
            where TEntity : class, ICustomerEntity
        {
            modelBuilder.Entity<TEntity>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(e => e.Customer)
                    .WithOne(relatedEntity)
                    .HasForeignKey<TEntity>(e => e.CustomerId)
                    .OnDelete(DeleteBehavior.Cascade);

                additionalConfig?.Invoke(entity);
            });
        }
        private void ConfigurePathologicalHistoryDetails(EntityTypeBuilder<PathologicalHistory> pathologicalHistory)
        {
            pathologicalHistory.OwnsOne(ph => ph.Surgery);
            pathologicalHistory.OwnsOne(ph => ph.MedicalTreatment);
            pathologicalHistory.OwnsOne(ph => ph.Medication);
            pathologicalHistory.OwnsOne(ph => ph.MedicationAllergy);
            pathologicalHistory.OwnsOne(ph => ph.MenstrualCycle);
            pathologicalHistory.OwnsOne(ph => ph.Contraceptives);
            pathologicalHistory.OwnsOne(ph => ph.EndocrineProblems);
            pathologicalHistory.OwnsOne(ph => ph.HeartProblems);
            pathologicalHistory.OwnsOne(ph => ph.OncologicalProblemDetails);
        }

        private void ConfigureProfessionalEvaluationDetails(EntityTypeBuilder<ProfessionalEvaluation> professionalEvaluationEntity)
        {
            professionalEvaluationEntity.OwnsOne(pe => pe.Hypotonia);

            professionalEvaluationEntity
                .HasMany(pe => pe.Fegs)
                .WithOne()
                .HasForeignKey(f => f.ProfessionalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);

            professionalEvaluationEntity
                .HasMany(pe => pe.Adiposities)
                .WithOne()
                .HasForeignKey(a => a.ProfessionalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);

            professionalEvaluationEntity
                .HasMany(pe => pe.StretchMarks)
                .WithOne()
                .HasForeignKey(sm => sm.ProfessionalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);

            professionalEvaluationEntity
                .HasMany(pe => pe.BiometricControls)
                .WithOne()
                .HasForeignKey(bc => bc.ProfessionalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);

            professionalEvaluationEntity
                .HasMany(pe => pe.Protocols)
                .WithOne()
                .HasForeignKey(p => p.ProfessionalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}