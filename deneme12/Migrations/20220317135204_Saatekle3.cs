using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class Saatekle3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SaatId",
                table: "DersProgrami",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_SaatId",
                table: "DersProgrami",
                column: "SaatId");

            migrationBuilder.AddForeignKey(
                name: "FK_DersProgrami_Saat_SaatId",
                table: "DersProgrami",
                column: "SaatId",
                principalTable: "Saat",
                principalColumn: "SaatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DersProgrami_Saat_SaatId",
                table: "DersProgrami");

            migrationBuilder.DropIndex(
                name: "IX_DersProgrami_SaatId",
                table: "DersProgrami");

            migrationBuilder.DropColumn(
                name: "SaatId",
                table: "DersProgrami");
        }
    }
}
