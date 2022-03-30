using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class Ekleresim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Resim",
                table: "Ogrenci",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Resim",
                table: "Ogrenci");
        }
    }
}
