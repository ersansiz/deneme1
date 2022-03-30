using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class DersListekle1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DerslistId",
                table: "OgrenciDers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DerslistId",
                table: "DersProgrami",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DersList",
                columns: table => new
                {
                    DerslistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersList", x => x.DerslistId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciDers_DerslistId",
                table: "OgrenciDers",
                column: "DerslistId");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_DerslistId",
                table: "DersProgrami",
                column: "DerslistId");

            migrationBuilder.AddForeignKey(
                name: "FK_DersProgrami_DersList_DerslistId",
                table: "DersProgrami",
                column: "DerslistId",
                principalTable: "DersList",
                principalColumn: "DerslistId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDers_DersList_DerslistId",
                table: "OgrenciDers",
                column: "DerslistId",
                principalTable: "DersList",
                principalColumn: "DerslistId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DersProgrami_DersList_DerslistId",
                table: "DersProgrami");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDers_DersList_DerslistId",
                table: "OgrenciDers");

            migrationBuilder.DropTable(
                name: "DersList");

            migrationBuilder.DropIndex(
                name: "IX_OgrenciDers_DerslistId",
                table: "OgrenciDers");

            migrationBuilder.DropIndex(
                name: "IX_DersProgrami_DerslistId",
                table: "DersProgrami");

            migrationBuilder.DropColumn(
                name: "DerslistId",
                table: "OgrenciDers");

            migrationBuilder.DropColumn(
                name: "DerslistId",
                table: "DersProgrami");
        }
    }
}
