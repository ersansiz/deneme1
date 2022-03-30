using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class Gunekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gun",
                columns: table => new
                {
                    GunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GunName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gun", x => x.GunId);
                });

            migrationBuilder.CreateTable(
                name: "GunSinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    GunID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunSinif", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GunSinif_Gun_GunID",
                        column: x => x.GunID,
                        principalTable: "Gun",
                        principalColumn: "GunId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunSinif_Sinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinif",
                        principalColumn: "SinifId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GunSinif_GunID",
                table: "GunSinif",
                column: "GunID");

            migrationBuilder.CreateIndex(
                name: "IX_GunSinif_SinifId",
                table: "GunSinif",
                column: "SinifId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GunSinif");

            migrationBuilder.DropTable(
                name: "Gun");
        }
    }
}
