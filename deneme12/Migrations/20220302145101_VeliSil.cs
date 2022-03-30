using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class VeliSil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OgrenciName",
                table: "Veli");

            migrationBuilder.DropColumn(
                name: "OgrenciTcKimlik",
                table: "Veli");

            migrationBuilder.DropColumn(
                name: "VeliName",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "VeliTcKimlik",
                table: "Ogrenci");

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Veli",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Ogrenci",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Veli",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OgrenciName",
                table: "Veli",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OgrenciTcKimlik",
                table: "Veli",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefon",
                table: "Ogrenci",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VeliName",
                table: "Ogrenci",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VeliTcKimlik",
                table: "Ogrenci",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);
        }
    }
}
