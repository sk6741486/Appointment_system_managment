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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clinic_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clinic_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clinic_phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clinic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "doctor_detail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sepicaligation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor_detail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "patient_detail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patient_detail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "appointment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clinic_registration_no = table.Column<int>(type: "int", nullable: false),
                    Obj_ClinicID = table.Column<int>(type: "int", nullable: true),
                    Doctor_ID = table.Column<int>(type: "int", nullable: false),
                    Obj_Doctor_DetailsID = table.Column<int>(type: "int", nullable: true),
                    Patient_registration_no = table.Column<int>(type: "int", nullable: false),
                    Obj_Patient_detailID = table.Column<int>(type: "int", nullable: true),
                    Appointment_date_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appointment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_appointment_clinic_Obj_ClinicID",
                        column: x => x.Obj_ClinicID,
                        principalTable: "clinic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_appointment_doctor_detail_Obj_Doctor_DetailsID",
                        column: x => x.Obj_Doctor_DetailsID,
                        principalTable: "doctor_detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_appointment_patient_detail_Obj_Patient_detailID",
                        column: x => x.Obj_Patient_detailID,
                        principalTable: "patient_detail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_appointment_Obj_ClinicID",
                table: "appointment",
                column: "Obj_ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_Obj_Doctor_DetailsID",
                table: "appointment",
                column: "Obj_Doctor_DetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_appointment_Obj_Patient_detailID",
                table: "appointment",
                column: "Obj_Patient_detailID");
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
