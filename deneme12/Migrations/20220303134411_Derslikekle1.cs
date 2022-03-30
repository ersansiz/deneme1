using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class Derslikekle1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DerslikSinif_Derslik_DerslikID",
                table: "DerslikSinif");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Derslik",
                table: "Derslik");

            migrationBuilder.RenameTable(
                name: "Derslik",
                newName: "Dersliks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dersliks",
                table: "Dersliks",
                column: "DerslikId");

            migrationBuilder.AddForeignKey(
                name: "FK_DerslikSinif_Dersliks_DerslikID",
                table: "DerslikSinif",
                column: "DerslikID",
                principalTable: "Dersliks",
                principalColumn: "DerslikId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DerslikSinif_Dersliks_DerslikID",
                table: "DerslikSinif");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dersliks",
                table: "Dersliks");

            migrationBuilder.RenameTable(
                name: "Dersliks",
                newName: "Derslik");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Derslik",
                table: "Derslik",
                column: "DerslikId");

            migrationBuilder.AddForeignKey(
                name: "FK_DerslikSinif_Derslik_DerslikID",
                table: "DerslikSinif",
                column: "DerslikID",
                principalTable: "Derslik",
                principalColumn: "DerslikId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
