using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbsenzAPPDBHosting.Migrations
{
    /// <inheritdoc />
    public partial class EmailToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Schueler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Lehrer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Schueler");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Lehrer");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Admin");
        }
    }
}
