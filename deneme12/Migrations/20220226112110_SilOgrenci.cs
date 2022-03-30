using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class SilOgrenci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_Ogrenci_OgrenciID",
                table: "Sinif");

            migrationBuilder.DropIndex(
                name: "IX_Sinif_OgrenciID",
                table: "Sinif");

            migrationBuilder.DropColumn(
                name: "OgrenciID",
                table: "Sinif");

            migrationBuilder.RenameColumn(
                name: "SinifID",
                table: "Sinif",
                newName: "SinifId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SinifId",
                table: "Sinif",
                newName: "SinifID");

            migrationBuilder.AddColumn<int>(
                name: "OgrenciID",
                table: "Sinif",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sinif_OgrenciID",
                table: "Sinif",
                column: "OgrenciID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Ogrenci_OgrenciID",
                table: "Sinif",
                column: "OgrenciID",
                principalTable: "Ogrenci",
                principalColumn: "OgrenciID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
