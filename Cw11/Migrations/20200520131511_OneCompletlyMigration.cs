using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cw11.Migrations
{
    public partial class OneCompletlyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doktor",
                columns: table => new
                {
                    IdDoctor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktor", x => x.IdDoctor);
                });

            migrationBuilder.CreateTable(
                name: "Lekarstwo",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lekarstwo", x => x.IdMedicament);
                });

            migrationBuilder.CreateTable(
                name: "Pacjent",
                columns: table => new
                {
                    IdPatient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacjent", x => x.IdPatient);
                });

            migrationBuilder.CreateTable(
                name: "Recepta",
                columns: table => new
                {
                    IdPrescription = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    IdPatient = table.Column<int>(nullable: false),
                    IdDoctor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepta", x => x.IdPrescription);
                });

            migrationBuilder.CreateTable(
                name: "Recepta_Lekarstwo",
                columns: table => new
                {
                    IdMedicament = table.Column<int>(nullable: false),
                    IdPrescription = table.Column<int>(nullable: false),
                    Dose = table.Column<int>(nullable: true),
                    Details = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepta_Lekarstwo", x => new { x.IdMedicament, x.IdPrescription });
                });

            migrationBuilder.InsertData(
                table: "Doktor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "zawajda@gmail.com", "Marcin", "Zawajdowski" },
                    { 2, "cukierek@gmail.com", "Patryk", "Cukierek" }
                });

            migrationBuilder.InsertData(
                table: "Lekarstwo",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Na odpornosc", "Rutinoscorbin", "Tabletki" },
                    { 2, "Na apetyt", "Apetizer", "Syrop" }
                });

            migrationBuilder.InsertData(
                table: "Pacjent",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1996, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ola", "Mała" },
                    { 2, new DateTime(1991, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Władek", "Cichy" }
                });

            migrationBuilder.InsertData(
                table: "Recepta",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 20, 15, 15, 11, 464, DateTimeKind.Local).AddTicks(5310), new DateTime(2020, 6, 20, 15, 15, 11, 468, DateTimeKind.Local).AddTicks(5873), 1, 1 },
                    { 2, new DateTime(2020, 5, 20, 15, 15, 11, 468, DateTimeKind.Local).AddTicks(7626), new DateTime(2020, 6, 20, 15, 15, 11, 468, DateTimeKind.Local).AddTicks(7654), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Recepta_Lekarstwo",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "Po posiłku", 2 },
                    { 2, 2, "W trakcie posiłku", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doktor");

            migrationBuilder.DropTable(
                name: "Lekarstwo");

            migrationBuilder.DropTable(
                name: "Pacjent");

            migrationBuilder.DropTable(
                name: "Recepta");

            migrationBuilder.DropTable(
                name: "Recepta_Lekarstwo");
        }
    }
}
