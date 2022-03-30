using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class SinifEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ogrenci_SinifID",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "DersName",
                table: "Sinif");

            migrationBuilder.DropColumn(
                name: "OgretmenName",
                table: "Sinif");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_SinifID",
                table: "Ogrenci",
                column: "SinifID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ogrenci_SinifID",
                table: "Ogrenci");

            migrationBuilder.AddColumn<string>(
                name: "DersName",
                table: "Sinif",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OgretmenName",
                table: "Sinif",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_SinifID",
                table: "Ogrenci",
                column: "SinifID");
        }
    }
}
