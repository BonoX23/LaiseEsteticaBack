using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class TableAdjustment5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StretchMarks",
                table: "StretchMarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Protocols",
                table: "Protocols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feg",
                table: "Feg");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BiometricControl",
                table: "BiometricControl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adiposity",
                table: "Adiposity");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "StretchMarks",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Protocols",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "Hypotonia_Id",
                table: "ProfessionalEvaluations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Feg",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "BiometricControl",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Adiposity",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StretchMarks",
                table: "StretchMarks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Protocols",
                table: "Protocols",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feg",
                table: "Feg",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BiometricControl",
                table: "BiometricControl",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adiposity",
                table: "Adiposity",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StretchMarks_ProfessionalEvaluationId",
                table: "StretchMarks",
                column: "ProfessionalEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_Protocols_ProfessionalEvaluationId",
                table: "Protocols",
                column: "ProfessionalEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_Feg_ProfessionalEvaluationId",
                table: "Feg",
                column: "ProfessionalEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_BiometricControl_ProfessionalEvaluationId",
                table: "BiometricControl",
                column: "ProfessionalEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_Adiposity_ProfessionalEvaluationId",
                table: "Adiposity",
                column: "ProfessionalEvaluationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StretchMarks",
                table: "StretchMarks");

            migrationBuilder.DropIndex(
                name: "IX_StretchMarks_ProfessionalEvaluationId",
                table: "StretchMarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Protocols",
                table: "Protocols");

            migrationBuilder.DropIndex(
                name: "IX_Protocols_ProfessionalEvaluationId",
                table: "Protocols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Feg",
                table: "Feg");

            migrationBuilder.DropIndex(
                name: "IX_Feg_ProfessionalEvaluationId",
                table: "Feg");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BiometricControl",
                table: "BiometricControl");

            migrationBuilder.DropIndex(
                name: "IX_BiometricControl_ProfessionalEvaluationId",
                table: "BiometricControl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adiposity",
                table: "Adiposity");

            migrationBuilder.DropIndex(
                name: "IX_Adiposity_ProfessionalEvaluationId",
                table: "Adiposity");

            migrationBuilder.DropColumn(
                name: "Hypotonia_Id",
                table: "ProfessionalEvaluations");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "StretchMarks",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Protocols",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Feg",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "BiometricControl",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Adiposity",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StretchMarks",
                table: "StretchMarks",
                columns: new[] { "ProfessionalEvaluationId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Protocols",
                table: "Protocols",
                columns: new[] { "ProfessionalEvaluationId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Feg",
                table: "Feg",
                columns: new[] { "ProfessionalEvaluationId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BiometricControl",
                table: "BiometricControl",
                columns: new[] { "ProfessionalEvaluationId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adiposity",
                table: "Adiposity",
                columns: new[] { "ProfessionalEvaluationId", "Id" });
        }
    }
}
