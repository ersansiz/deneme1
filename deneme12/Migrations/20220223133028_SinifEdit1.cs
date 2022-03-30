using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class SinifEdit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenci_Sinif_SinifID",
                table: "Ogrenci");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenci_SinifID",
                table: "Ogrenci");

            migrationBuilder.DropColumn(
                name: "SinifID",
                table: "Ogrenci");

            migrationBuilder.AddColumn<int>(
                name: "OgrenciID",
                table: "Sinif",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OgrenciSinif",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgrenciId = table.Column<int>(type: "int", nullable: false),
                    SinifID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgrenciSinif", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgrenciSinif_Ogrenci_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "Ogrenci",
                        principalColumn: "OgrenciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OgrenciSinif_Sinif_SinifID",
                        column: x => x.SinifID,
                        principalTable: "Sinif",
                        principalColumn: "SinifID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sinif_OgrenciID",
                table: "Sinif",
                column: "OgrenciID");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciSinif_OgrenciId",
                table: "OgrenciSinif",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_OgrenciSinif_SinifID",
                table: "OgrenciSinif",
                column: "SinifID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sinif_Ogrenci_OgrenciID",
                table: "Sinif",
                column: "OgrenciID",
                principalTable: "Ogrenci",
                principalColumn: "OgrenciID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sinif_Ogrenci_OgrenciID",
                table: "Sinif");

            migrationBuilder.DropTable(
                name: "OgrenciSinif");

            migrationBuilder.DropIndex(
                name: "IX_Sinif_OgrenciID",
                table: "Sinif");

            migrationBuilder.DropColumn(
                name: "OgrenciID",
                table: "Sinif");

            migrationBuilder.AddColumn<int>(
                name: "SinifID",
                table: "Ogrenci",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_SinifID",
                table: "Ogrenci",
                column: "SinifID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenci_Sinif_SinifID",
                table: "Ogrenci",
                column: "SinifID",
                principalTable: "Sinif",
                principalColumn: "SinifID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
