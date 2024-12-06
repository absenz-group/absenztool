using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbsenzAPPDBHosting.Migrations
{
    /// <inheritdoc />
    public partial class DbRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Passwort",
                table: "Lehrer");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Admin");

            migrationBuilder.RenameColumn(
                name: "Schueler",
                table: "Absenzen",
                newName: "Notiz");

            migrationBuilder.AlterColumn<int>(
                name: "Lehrer",
                table: "Absenzen",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Absenzgrund",
                table: "Absenzen",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SchuelerId",
                table: "Absenzen",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Absenzen_SchuelerId",
                table: "Absenzen",
                column: "SchuelerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absenzen_Schueler_SchuelerId",
                table: "Absenzen",
                column: "SchuelerId",
                principalTable: "Schueler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absenzen_Schueler_SchuelerId",
                table: "Absenzen");

            migrationBuilder.DropIndex(
                name: "IX_Absenzen_SchuelerId",
                table: "Absenzen");

            migrationBuilder.DropColumn(
                name: "SchuelerId",
                table: "Absenzen");

            migrationBuilder.RenameColumn(
                name: "Notiz",
                table: "Absenzen",
                newName: "Schueler");

            migrationBuilder.AddColumn<string>(
                name: "Passwort",
                table: "Lehrer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Password",
                table: "Admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Lehrer",
                table: "Absenzen",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Absenzgrund",
                table: "Absenzen",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
