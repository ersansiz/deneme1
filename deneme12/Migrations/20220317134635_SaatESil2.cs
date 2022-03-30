using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class SaatESil2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Saat",
                table: "DersProgramiList");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Saat",
                table: "DersProgramiList",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
