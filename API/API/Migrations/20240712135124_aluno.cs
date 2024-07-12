using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class aluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlunoId",
                table: "Imcs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imcs_AlunoId",
                table: "Imcs",
                column: "AlunoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imcs_Alunos_AlunoId",
                table: "Imcs",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "AlunoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imcs_Alunos_AlunoId",
                table: "Imcs");

            migrationBuilder.DropIndex(
                name: "IX_Imcs_AlunoId",
                table: "Imcs");

            migrationBuilder.DropColumn(
                name: "AlunoId",
                table: "Imcs");
        }
    }
}
