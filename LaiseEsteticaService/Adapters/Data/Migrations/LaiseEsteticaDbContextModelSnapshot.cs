﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(LaiseEsteticaDbContext))]
    partial class LaiseEsteticaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.AestheticHistory.Entities.AestheticHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BodyCosmetics")
                        .HasColumnType("int");

                    b.Property<string>("BodyCosmeticsReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CosmeticSurgery")
                        .HasColumnType("int");

                    b.Property<string>("CosmeticSurgeryReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Sunscreen")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("AestheticHistories");
                });

            modelBuilder.Entity("Domain.Customer.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complaint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Domain.Identity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Domain.Identity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Domain.Identity.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Domain.PathologicalHistory.Entities.PathologicalHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BloodPressure")
                        .HasColumnType("int");

                    b.Property<int>("BowelFunction")
                        .HasColumnType("int");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SuspectedPregnancy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("PathologicalHistories");
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.Adiposity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AdiposityFeature")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProfessionalEvaluationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionalEvaluationId");

                    b.ToTable("Adiposity");
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.BiometricControl", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Breeches")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DownperAbdomen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Hip")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LeftArm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("LeftThigh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProfessionalEvaluationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("RightArm")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RightThigh")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UpperAbdomen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Waist")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionalEvaluationId");

                    b.ToTable("BiometricControl");
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.Feg", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FegFeatures")
                        .HasColumnType("int");

                    b.Property<int>("FegIntensity")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProfessionalEvaluationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionalEvaluationId");

                    b.ToTable("Feg");
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Objectives")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observations")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreatmentProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("ProfessionalEvaluations");
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.Protocols", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ProfessionalEvaluationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProtocolCompleted")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionalEvaluationId");

                    b.ToTable("Protocols");
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.StretchMarks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProfessionalEvaluationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("StretchMarksFeature")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessionalEvaluationId");

                    b.ToTable("StretchMarks");
                });

            modelBuilder.Entity("Domain.SocialHistory.Entities.SocialHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AlcoholicBeverage")
                        .HasColumnType("int");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DaysOfTheWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HealthyEating")
                        .HasColumnType("int");

                    b.Property<int>("PhysicalActivity")
                        .HasColumnType("int");

                    b.Property<int>("PhysicalActivityFrequency")
                        .HasColumnType("int");

                    b.Property<int>("Smoker")
                        .HasColumnType("int");

                    b.Property<int>("WaterIntake")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("SocialHistories");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Domain.AestheticHistory.Entities.AestheticHistory", b =>
                {
                    b.HasOne("Domain.Customer.Entities.Customer", "Customer")
                        .WithOne("AestheticHistory")
                        .HasForeignKey("Domain.AestheticHistory.Entities.AestheticHistory", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Customer.Entities.Customer", b =>
                {
                    b.HasOne("Domain.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Identity.UserRole", b =>
                {
                    b.HasOne("Domain.Identity.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Identity.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.PathologicalHistory.Entities.PathologicalHistory", b =>
                {
                    b.HasOne("Domain.Customer.Entities.Customer", "Customer")
                        .WithOne("PathologicalHistory")
                        .HasForeignKey("Domain.PathologicalHistory.Entities.PathologicalHistory", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Domain.PathologicalHistory.Entities.Contraceptives", "Contraceptives", b1 =>
                        {
                            b1.Property<Guid>("PathologicalHistoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Frequency")
                                .HasColumnType("int");

                            b1.Property<string>("Reason")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PathologicalHistoryId");

                            b1.ToTable("PathologicalHistories");

                            b1.WithOwner()
                                .HasForeignKey("PathologicalHistoryId");
                        });

                    b.OwnsOne("Domain.PathologicalHistory.Entities.Endocrine", "EndocrineProblems", b1 =>
                        {
                            b1.Property<Guid>("PathologicalHistoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("EndocrineProblems")
                                .HasColumnType("int");

                            b1.Property<string>("OtherEndocrineProblems")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PathologicalHistoryId");

                            b1.ToTable("PathologicalHistories");

                            b1.WithOwner()
                                .HasForeignKey("PathologicalHistoryId");
                        });

                    b.OwnsOne("Domain.PathologicalHistory.Entities.HeartProblems", "HeartProblems", b1 =>
                        {
                            b1.Property<Guid>("PathologicalHistoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Frequency")
                                .HasColumnType("int");

                            b1.Property<int>("Pacemaker")
                                .HasColumnType("int");

                            b1.Property<string>("Reason")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PathologicalHistoryId");

                            b1.ToTable("PathologicalHistories");

                            b1.WithOwner()
                                .HasForeignKey("PathologicalHistoryId");
                        });

                    b.OwnsOne("Domain.PathologicalHistory.Entities.MedicalTreatment", "MedicalTreatment", b1 =>
                        {
                            b1.Property<Guid>("PathologicalHistoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Frequency")
                                .HasColumnType("int");

                            b1.Property<string>("Reason")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PathologicalHistoryId");

                            b1.ToTable("PathologicalHistories");

                            b1.WithOwner()
                                .HasForeignKey("PathologicalHistoryId");
                        });

                    b.OwnsOne("Domain.PathologicalHistory.Entities.Medication", "Medication", b1 =>
                        {
                            b1.Property<Guid>("PathologicalHistoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Frequency")
                                .HasColumnType("int");

                            b1.Property<string>("Reason")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PathologicalHistoryId");

                            b1.ToTable("PathologicalHistories");

                            b1.WithOwner()
                                .HasForeignKey("PathologicalHistoryId");
                        });

                    b.OwnsOne("Domain.PathologicalHistory.Entities.MedicationAllergy", "MedicationAllergy", b1 =>
                        {
                            b1.Property<Guid>("PathologicalHistoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Frequency")
                                .HasColumnType("int");

                            b1.Property<string>("Reason")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PathologicalHistoryId");

                            b1.ToTable("PathologicalHistories");

                            b1.WithOwner()
                                .HasForeignKey("PathologicalHistoryId");
                        });

                    b.OwnsOne("Domain.PathologicalHistory.Entities.MenstrualCycle", "MenstrualCycle", b1 =>
                        {
                            b1.Property<Guid>("PathologicalHistoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Frequency")
                                .HasColumnType("int");

                            b1.Property<string>("Reason")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PathologicalHistoryId");

                            b1.ToTable("PathologicalHistories");

                            b1.WithOwner()
                                .HasForeignKey("PathologicalHistoryId");
                        });

                    b.OwnsOne("Domain.PathologicalHistory.Entities.OncologicalProblem", "OncologicalProblemDetails", b1 =>
                        {
                            b1.Property<Guid>("PathologicalHistoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Location")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("OncologicalProblems")
                                .HasColumnType("int");

                            b1.Property<string>("Treatment")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("TreatmentTime")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PathologicalHistoryId");

                            b1.ToTable("PathologicalHistories");

                            b1.WithOwner()
                                .HasForeignKey("PathologicalHistoryId");
                        });

                    b.OwnsOne("Domain.PathologicalHistory.Entities.Surgery", "Surgery", b1 =>
                        {
                            b1.Property<Guid>("PathologicalHistoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Frequency")
                                .HasColumnType("int");

                            b1.Property<string>("Reason")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PathologicalHistoryId");

                            b1.ToTable("PathologicalHistories");

                            b1.WithOwner()
                                .HasForeignKey("PathologicalHistoryId");
                        });

                    b.Navigation("Contraceptives")
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("EndocrineProblems")
                        .IsRequired();

                    b.Navigation("HeartProblems")
                        .IsRequired();

                    b.Navigation("MedicalTreatment")
                        .IsRequired();

                    b.Navigation("Medication")
                        .IsRequired();

                    b.Navigation("MedicationAllergy")
                        .IsRequired();

                    b.Navigation("MenstrualCycle")
                        .IsRequired();

                    b.Navigation("OncologicalProblemDetails");

                    b.Navigation("Surgery")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.Adiposity", b =>
                {
                    b.HasOne("Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation", null)
                        .WithMany("Adiposities")
                        .HasForeignKey("ProfessionalEvaluationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.BiometricControl", b =>
                {
                    b.HasOne("Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation", null)
                        .WithMany("BiometricControls")
                        .HasForeignKey("ProfessionalEvaluationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.Feg", b =>
                {
                    b.HasOne("Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation", null)
                        .WithMany("Fegs")
                        .HasForeignKey("ProfessionalEvaluationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation", b =>
                {
                    b.HasOne("Domain.Customer.Entities.Customer", "Customer")
                        .WithOne("ProfessionalEvaluation")
                        .HasForeignKey("Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Domain.ProfessionalEvaluation.Entities.Hypotonia", "Hypotonia", b1 =>
                        {
                            b1.Property<Guid>("ProfessionalEvaluationId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Location")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<int>("Type")
                                .HasColumnType("int");

                            b1.HasKey("ProfessionalEvaluationId");

                            b1.ToTable("ProfessionalEvaluations");

                            b1.WithOwner()
                                .HasForeignKey("ProfessionalEvaluationId");
                        });

                    b.Navigation("Customer");

                    b.Navigation("Hypotonia");
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.Protocols", b =>
                {
                    b.HasOne("Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation", null)
                        .WithMany("Protocols")
                        .HasForeignKey("ProfessionalEvaluationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.StretchMarks", b =>
                {
                    b.HasOne("Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation", null)
                        .WithMany("StretchMarks")
                        .HasForeignKey("ProfessionalEvaluationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.SocialHistory.Entities.SocialHistory", b =>
                {
                    b.HasOne("Domain.Customer.Entities.Customer", "Customer")
                        .WithOne("SocialHistory")
                        .HasForeignKey("Domain.SocialHistory.Entities.SocialHistory", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Domain.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Customer.Entities.Customer", b =>
                {
                    b.Navigation("AestheticHistory")
                        .IsRequired();

                    b.Navigation("PathologicalHistory")
                        .IsRequired();

                    b.Navigation("ProfessionalEvaluation")
                        .IsRequired();

                    b.Navigation("SocialHistory")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Identity.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Domain.Identity.User", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Domain.ProfessionalEvaluation.Entities.ProfessionalEvaluation", b =>
                {
                    b.Navigation("Adiposities");

                    b.Navigation("BiometricControls");

                    b.Navigation("Fegs");

                    b.Navigation("Protocols");

                    b.Navigation("StretchMarks");
                });
#pragma warning restore 612, 618
        }
    }
}
