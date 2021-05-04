using Microsoft.EntityFrameworkCore.Migrations;

namespace AlisverisSepeti.Migrations
{
    public partial class JoinInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Kategoriler_KategoriId",
                table: "Urunler",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Kategoriler_KategoriId",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler");
        }
    }
}
