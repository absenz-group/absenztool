using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbsenzAPPDBHosting.Migrations
{
    /// <inheritdoc />
    public partial class DbRelationAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Modul",
                table: "Absenzen",
                newName: "ModulId");

            migrationBuilder.RenameColumn(
                name: "Lehrer",
                table: "Absenzen",
                newName: "LehrerId");

            migrationBuilder.RenameColumn(
                name: "Absenzgrund",
                table: "Absenzen",
                newName: "AbsenzgrundId");

            migrationBuilder.CreateTable(
                name: "CrossSchuelerEltern",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_SchuelerId = table.Column<int>(type: "int", nullable: false),
                    ID_ElternId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CrossSchuelerEltern", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CrossSchuelerEltern_Eltern_ID_ElternId",
                        column: x => x.ID_ElternId,
                        principalTable: "Eltern",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CrossSchuelerEltern_Schueler_ID_SchuelerId",
                        column: x => x.ID_SchuelerId,
                        principalTable: "Schueler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Absenzen_AbsenzgrundId",
                table: "Absenzen",
                column: "AbsenzgrundId");

            migrationBuilder.CreateIndex(
                name: "IX_Absenzen_LehrerId",
                table: "Absenzen",
                column: "LehrerId");

            migrationBuilder.CreateIndex(
                name: "IX_Absenzen_ModulId",
                table: "Absenzen",
                column: "ModulId");

            migrationBuilder.CreateIndex(
                name: "IX_CrossSchuelerEltern_ID_ElternId",
                table: "CrossSchuelerEltern",
                column: "ID_ElternId");

            migrationBuilder.CreateIndex(
                name: "IX_CrossSchuelerEltern_ID_SchuelerId",
                table: "CrossSchuelerEltern",
                column: "ID_SchuelerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Absenzen_Absenzgruende_AbsenzgrundId",
                table: "Absenzen",
                column: "AbsenzgrundId",
                principalTable: "Absenzgruende",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Absenzen_Lehrer_LehrerId",
                table: "Absenzen",
                column: "LehrerId",
                principalTable: "Lehrer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Absenzen_Module_ModulId",
                table: "Absenzen",
                column: "ModulId",
                principalTable: "Module",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Absenzen_Absenzgruende_AbsenzgrundId",
                table: "Absenzen");

            migrationBuilder.DropForeignKey(
                name: "FK_Absenzen_Lehrer_LehrerId",
                table: "Absenzen");

            migrationBuilder.DropForeignKey(
                name: "FK_Absenzen_Module_ModulId",
                table: "Absenzen");

            migrationBuilder.DropTable(
                name: "CrossSchuelerEltern");

            migrationBuilder.DropIndex(
                name: "IX_Absenzen_AbsenzgrundId",
                table: "Absenzen");

            migrationBuilder.DropIndex(
                name: "IX_Absenzen_LehrerId",
                table: "Absenzen");

            migrationBuilder.DropIndex(
                name: "IX_Absenzen_ModulId",
                table: "Absenzen");

            migrationBuilder.RenameColumn(
                name: "ModulId",
                table: "Absenzen",
                newName: "Modul");

            migrationBuilder.RenameColumn(
                name: "LehrerId",
                table: "Absenzen",
                newName: "Lehrer");

            migrationBuilder.RenameColumn(
                name: "AbsenzgrundId",
                table: "Absenzen",
                newName: "Absenzgrund");
        }
    }
}
