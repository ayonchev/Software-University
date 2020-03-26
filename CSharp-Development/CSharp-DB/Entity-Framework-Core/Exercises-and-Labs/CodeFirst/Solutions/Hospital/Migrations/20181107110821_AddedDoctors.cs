using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital.Migrations
{
    public partial class AddedDoctors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VisitationId",
                table: "Visitations",
                newName: "VisitationID");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "Patients",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "MedicamentId",
                table: "Medicaments",
                newName: "MedicamentID");

            migrationBuilder.RenameColumn(
                name: "DiagnoseId",
                table: "Diagnoses",
                newName: "DiagnoseID");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Visitations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DoctorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Specialty = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DoctorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visitations_DoctorId",
                table: "Visitations",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Doctors_DoctorId",
                table: "Visitations",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "DoctorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Doctors_DoctorId",
                table: "Visitations");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Visitations_DoctorId",
                table: "Visitations");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Visitations");

            migrationBuilder.RenameColumn(
                name: "VisitationID",
                table: "Visitations",
                newName: "VisitationId");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "Patients",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "MedicamentID",
                table: "Medicaments",
                newName: "MedicamentId");

            migrationBuilder.RenameColumn(
                name: "DiagnoseID",
                table: "Diagnoses",
                newName: "DiagnoseId");
        }
    }
}
