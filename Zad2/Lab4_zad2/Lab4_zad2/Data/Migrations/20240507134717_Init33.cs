using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab4_zad2.Migrations
{
    /// <inheritdoc />
    public partial class Init33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "Game",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url",
                table: "Game");
        }
    }
}
