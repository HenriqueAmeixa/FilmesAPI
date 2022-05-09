using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmesAPI.Migrations
{
    public partial class Cinema_Endereco11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Enderecos_IdEndereco",
                table: "Cinemas");

            migrationBuilder.RenameColumn(
                name: "IdEndereco",
                table: "Cinemas",
                newName: "EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Cinemas_IdEndereco",
                table: "Cinemas",
                newName: "IX_Cinemas_EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoId",
                table: "Cinemas",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinemas_Enderecos_EnderecoId",
                table: "Cinemas");

            migrationBuilder.RenameColumn(
                name: "EnderecoId",
                table: "Cinemas",
                newName: "IdEndereco");

            migrationBuilder.RenameIndex(
                name: "IX_Cinemas_EnderecoId",
                table: "Cinemas",
                newName: "IX_Cinemas_IdEndereco");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinemas_Enderecos_IdEndereco",
                table: "Cinemas",
                column: "IdEndereco",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
