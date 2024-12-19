using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Complaint = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AestheticHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CosmeticSurgery = table.Column<int>(type: "int", nullable: false),
                    CosmeticSurgeryReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sunscreen = table.Column<int>(type: "int", nullable: false),
                    BodyCosmetics = table.Column<int>(type: "int", nullable: false),
                    BodyCosmeticsReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AestheticHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AestheticHistories_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PathologicalHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Surgery_Frequency = table.Column<int>(type: "int", nullable: false),
                    Surgery_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalTreatment_Frequency = table.Column<int>(type: "int", nullable: false),
                    MedicalTreatment_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medication_Frequency = table.Column<int>(type: "int", nullable: false),
                    Medication_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicationAllergy_Frequency = table.Column<int>(type: "int", nullable: false),
                    MedicationAllergy_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BowelFunction = table.Column<int>(type: "int", nullable: false),
                    MenstrualCycle_Frequency = table.Column<int>(type: "int", nullable: false),
                    MenstrualCycle_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraceptives_Frequency = table.Column<int>(type: "int", nullable: false),
                    Contraceptives_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuspectedPregnancy = table.Column<int>(type: "int", nullable: false),
                    BloodPressure = table.Column<int>(type: "int", nullable: false),
                    EndocrineProblems_EndocrineProblems = table.Column<int>(type: "int", nullable: false),
                    EndocrineProblems_OtherEndocrineProblems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeartProblems_Pacemaker = table.Column<int>(type: "int", nullable: false),
                    HeartProblems_Frequency = table.Column<int>(type: "int", nullable: false),
                    HeartProblems_Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OncologicalProblemDetails_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OncologicalProblemDetails_TreatmentTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OncologicalProblemDetails_Treatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OncologicalProblemDetails_OncologicalProblems = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PathologicalHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PathologicalHistories_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfessionalEvaluations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hypotonia_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Hypotonia_Type = table.Column<int>(type: "int", nullable: true),
                    Hypotonia_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Objectives = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreatmentProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfessionalEvaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfessionalEvaluations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhysicalActivity = table.Column<int>(type: "int", nullable: false),
                    PhysicalActivityFrequency = table.Column<int>(type: "int", nullable: false),
                    DaysOfTheWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HealthyEating = table.Column<int>(type: "int", nullable: false),
                    WaterIntake = table.Column<int>(type: "int", nullable: false),
                    AlcoholicBeverage = table.Column<int>(type: "int", nullable: false),
                    Smoker = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialHistories_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adiposity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdiposityFeature = table.Column<int>(type: "int", nullable: false),
                    ProfessionalEvaluationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adiposity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adiposity_ProfessionalEvaluations_ProfessionalEvaluationId",
                        column: x => x.ProfessionalEvaluationId,
                        principalTable: "ProfessionalEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BiometricControl",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpperAbdomen = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DownperAbdomen = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Waist = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Hip = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Breeches = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RightThigh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeftThigh = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RightArm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeftArm = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProfessionalEvaluationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiometricControl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BiometricControl_ProfessionalEvaluations_ProfessionalEvaluationId",
                        column: x => x.ProfessionalEvaluationId,
                        principalTable: "ProfessionalEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feg",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FegFeatures = table.Column<int>(type: "int", nullable: false),
                    FegIntensity = table.Column<int>(type: "int", nullable: false),
                    ProfessionalEvaluationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feg", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feg_ProfessionalEvaluations_ProfessionalEvaluationId",
                        column: x => x.ProfessionalEvaluationId,
                        principalTable: "ProfessionalEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Protocols",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProtocolCompleted = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfessionalEvaluationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Protocols", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Protocols_ProfessionalEvaluations_ProfessionalEvaluationId",
                        column: x => x.ProfessionalEvaluationId,
                        principalTable: "ProfessionalEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StretchMarks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StretchMarksFeature = table.Column<int>(type: "int", nullable: false),
                    ProfessionalEvaluationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StretchMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StretchMarks_ProfessionalEvaluations_ProfessionalEvaluationId",
                        column: x => x.ProfessionalEvaluationId,
                        principalTable: "ProfessionalEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adiposity_ProfessionalEvaluationId",
                table: "Adiposity",
                column: "ProfessionalEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_AestheticHistories_CustomerId",
                table: "AestheticHistories",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricControl_ProfessionalEvaluationId",
                table: "BiometricControl",
                column: "ProfessionalEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feg_ProfessionalEvaluationId",
                table: "Feg",
                column: "ProfessionalEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_PathologicalHistories_CustomerId",
                table: "PathologicalHistories",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProfessionalEvaluations_CustomerId",
                table: "ProfessionalEvaluations",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_ProfessionalEvaluationId",
                table: "Protocols",
                column: "ProfessionalEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialHistories_CustomerId",
                table: "SocialHistories",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StretchMarks_ProfessionalEvaluationId",
                table: "StretchMarks",
                column: "ProfessionalEvaluationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adiposity");

            migrationBuilder.DropTable(
                name: "AestheticHistories");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BiometricControl");

            migrationBuilder.DropTable(
                name: "Feg");

            migrationBuilder.DropTable(
                name: "PathologicalHistories");

            migrationBuilder.DropTable(
                name: "Protocols");

            migrationBuilder.DropTable(
                name: "SocialHistories");

            migrationBuilder.DropTable(
                name: "StretchMarks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ProfessionalEvaluations");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
