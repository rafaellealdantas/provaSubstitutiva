using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class imcresult : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imcresult",
                table: "Imcs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "imcvalor",
                table: "Imcs",
                type: "REAL",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imcresult",
                table: "Imcs");

            migrationBuilder.DropColumn(
                name: "imcvalor",
                table: "Imcs");
        }
    }
}
