using Microsoft.EntityFrameworkCore.Migrations;

namespace deneme12.Migrations
{
    public partial class DersProgramiListEkle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DersProgramiListId",
                table: "DersProgrami",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DersProgramiList",
                columns: table => new
                {
                    DersProgramiListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DersProgramiList", x => x.DersProgramiListId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DersProgrami_DersProgramiListId",
                table: "DersProgrami",
                column: "DersProgramiListId");

            migrationBuilder.AddForeignKey(
                name: "FK_DersProgrami_DersProgramiList_DersProgramiListId",
                table: "DersProgrami",
                column: "DersProgramiListId",
                principalTable: "DersProgramiList",
                principalColumn: "DersProgramiListId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DersProgrami_DersProgramiList_DersProgramiListId",
                table: "DersProgrami");

            migrationBuilder.DropTable(
                name: "DersProgramiList");

            migrationBuilder.DropIndex(
                name: "IX_DersProgrami_DersProgramiListId",
                table: "DersProgrami");

            migrationBuilder.DropColumn(
                name: "DersProgramiListId",
                table: "DersProgrami");
        }
    }
}
