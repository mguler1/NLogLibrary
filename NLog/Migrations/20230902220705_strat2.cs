using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLogLibrary.Migrations
{
    /// <inheritdoc />
    public partial class strat2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Exeption",
                table: "Logs",
                newName: "Exception");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Exception",
                table: "Logs",
                newName: "Exeption");
        }
    }
}
