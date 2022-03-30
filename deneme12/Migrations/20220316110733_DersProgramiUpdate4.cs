using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class DersProgramiUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OgrenciId",
                table: "DersProgrami");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OgrenciId",
                table: "DersProgrami",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
