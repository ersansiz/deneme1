using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class DersProgramiEkle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DersProgrami",
                columns: table => new
                {
                    DersProgramiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Saat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SinifId = table.Column<int>(type: "int", nullable: false),
                    GunId = table.Column<int>(type: "int", nullable: false),
                    DerslikId = table.Column<int>(type: "int", nullable: false),
                    DersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersProgrami", x => x.DersProgramiId);
                    table.ForeignKey(
                        name: "FK_DersProgrami_Ders_DersId",
                        column: x => x.DersId,
                        principalTable: "Ders",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersProgrami_Dersliks_DerslikId",
                        column: x => x.DerslikId,
                        principalTable: "Dersliks",
                        principalColumn: "DerslikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersProgrami_Gun_GunId",
                        column: x => x.GunId,
                        principalTable: "Gun",
                        principalColumn: "GunId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DersProgrami_Sinif_SinifId",
                        column: x => x.SinifId,
                        principalTable: "Sinif",
                        principalColumn: "SinifId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_DersId",
                table: "DersProgrami",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_DerslikId",
                table: "DersProgrami",
                column: "DerslikId");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_GunId",
                table: "DersProgrami",
                column: "GunId");

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_SinifId",
                table: "DersProgrami",
                column: "SinifId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DersProgrami");
        }
    }
}
