using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Appointment_system_managment.Migrations
{
    public partial class Appointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clinic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clinic_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clinic_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clinic_phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "doctor_detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sepicaligation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor_detail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "patient_detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient_detail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "appointment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicId = table.Column<int>(type: "int", nullable: false),
                    Doctor_DetailID = table.Column<int>(type: "int", nullable: false),
                    Patient_DetailID = table.Column<int>(type: "int", nullable: false),
                    Appointment_date_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_appointment_clinic_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "clinic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appointment_doctor_detail_Doctor_DetailID",
                        column: x => x.Doctor_DetailID,
                        principalTable: "doctor_detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_appointment_patient_detail_Patient_DetailID",
                        column: x => x.Patient_DetailID,
                        principalTable: "patient_detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_appointment_ClinicId",
                table: "appointment",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_Doctor_DetailID",
                table: "appointment",
                column: "Doctor_DetailID");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_Patient_DetailID",
                table: "appointment",
                column: "Patient_DetailID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appointment");

            migrationBuilder.DropTable(
                name: "clinic");

            migrationBuilder.DropTable(
                name: "doctor_detail");

            migrationBuilder.DropTable(
                name: "patient_detail");
        }
    }
}
