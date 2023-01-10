using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuiviVaccinationCovid.Migrations
{
    /// <inheritdoc />
    public partial class AjoutTableVaccin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nom",
                table: "Doses");

            migrationBuilder.AddColumn<int>(
                name: "VaccinId",
                table: "Doses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Vaccins",
                columns: table => new
                {
                    VaccinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccins", x => x.VaccinId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doses_VaccinId",
                table: "Doses",
                column: "VaccinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doses_Vaccins_VaccinId",
                table: "Doses",
                column: "VaccinId",
                principalTable: "Vaccins",
                principalColumn: "VaccinId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doses_Vaccins_VaccinId",
                table: "Doses");

            migrationBuilder.DropTable(
                name: "Vaccins");

            migrationBuilder.DropIndex(
                name: "IX_Doses_VaccinId",
                table: "Doses");

            migrationBuilder.DropColumn(
                name: "VaccinId",
                table: "Doses");

            migrationBuilder.AddColumn<string>(
                name: "Nom",
                table: "Doses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
