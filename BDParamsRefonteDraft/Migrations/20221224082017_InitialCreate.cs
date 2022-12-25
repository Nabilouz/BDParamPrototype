using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BDParamsRefonteDraft.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modeles",
                columns: table => new
                {
                    ModeleID = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeles", x => x.ModeleID);
                });

            migrationBuilder.CreateTable(
                name: "Capteurs",
                columns: table => new
                {
                    CapteurId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    ModeleID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capteurs", x => x.CapteurId);
                    table.ForeignKey(
                        name: "FK_Capteurs_Modeles_ModeleID",
                        column: x => x.ModeleID,
                        principalTable: "Modeles",
                        principalColumn: "ModeleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parametres",
                columns: table => new
                {
                    ParametreId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "text", nullable: false),
                    Valeur = table.Column<double>(type: "double precision", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ModeleID = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametres", x => x.ParametreId);
                    table.ForeignKey(
                        name: "FK_Parametres_Modeles_ModeleID",
                        column: x => x.ModeleID,
                        principalTable: "Modeles",
                        principalColumn: "ModeleID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Capteurs_ModeleID",
                table: "Capteurs",
                column: "ModeleID");

            migrationBuilder.CreateIndex(
                name: "IX_Parametres_ModeleID",
                table: "Parametres",
                column: "ModeleID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Capteurs");

            migrationBuilder.DropTable(
                name: "Parametres");

            migrationBuilder.DropTable(
                name: "Modeles");
        }
    }
}
