using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class Derslikekle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Derslik",
                table: "Sinif");

            migrationBuilder.DropColumn(
                name: "Derslik",
                table: "Ders");

            migrationBuilder.DropColumn(
                name: "OgretmenName",
                table: "Ders");

            migrationBuilder.RenameColumn(
                name: "DersID",
                table: "Ders",
                newName: "DersId");

            migrationBuilder.CreateTable(
                name: "Derslik",
                columns: table => new
                {
                    DerslikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DerslikName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Derslik", x => x.DerslikId);
                });

            migrationBuilder.CreateTable(
                name: "DerslikSinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    DerslikID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerslikSinif", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DerslikSinif_Derslik_DerslikID",
                        column: x => x.DerslikID,
                        principalTable: "Derslik",
                        principalColumn: "DerslikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DerslikSinif_Sinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinif",
                        principalColumn: "SinifId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DerslikSinif_DerslikID",
                table: "DerslikSinif",
                column: "DerslikID");

            migrationBuilder.CreateIndex(
                name: "IX_DerslikSinif_SinifId",
                table: "DerslikSinif",
                column: "SinifId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DerslikSinif");

            migrationBuilder.DropTable(
                name: "Derslik");

            migrationBuilder.RenameColumn(
                name: "DersId",
                table: "Ders",
                newName: "DersID");

            migrationBuilder.AddColumn<string>(
                name: "Derslik",
                table: "Sinif",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Derslik",
                table: "Ders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OgretmenName",
                table: "Ders",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
