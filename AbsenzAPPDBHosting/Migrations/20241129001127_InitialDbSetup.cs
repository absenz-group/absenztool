using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbsenzAPPDBHosting.Migrations
{
    /// <inheritdoc />
    public partial class InitialDbSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Absenzen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Schueler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Absenzgrund = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lehrer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modul = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absenzen", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Absenzen");
        }
    }
}
