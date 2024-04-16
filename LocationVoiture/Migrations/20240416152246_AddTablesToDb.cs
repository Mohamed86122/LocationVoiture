using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocationVoiture.Migrations
{
    public partial class AddTablesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CIN = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Marques",
                columns: table => new
                {
                    MarqueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marques", x => x.MarqueId);
                });

            migrationBuilder.CreateTable(
                name: "Voitures",
                columns: table => new
                {
                    VoitureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Matricule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nbr_portes = table.Column<int>(type: "int", nullable: false),
                    Nbr_places = table.Column<int>(type: "int", nullable: false),
                    Photo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Couleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarqueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voitures", x => x.VoitureId);
                    table.ForeignKey(
                        name: "FK_Voitures_Marques_MarqueId",
                        column: x => x.MarqueId,
                        principalTable: "Marques",
                        principalColumn: "MarqueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assurances",
                columns: table => new
                {
                    AssuranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Agence = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Debut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_Fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prix = table.Column<int>(type: "int", nullable: false),
                    VoitureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assurances", x => x.AssuranceId);
                    table.ForeignKey(
                        name: "FK_Assurances_Voitures_VoitureId",
                        column: x => x.VoitureId,
                        principalTable: "Voitures",
                        principalColumn: "VoitureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_debut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Retour = table.Column<bool>(type: "bit", nullable: false),
                    Prix_jour = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    VoitureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Locations_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locations_Voitures_VoitureId",
                        column: x => x.VoitureId,
                        principalTable: "Voitures",
                        principalColumn: "VoitureId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assurances_VoitureId",
                table: "Assurances",
                column: "VoitureId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ClientId",
                table: "Locations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_VoitureId",
                table: "Locations",
                column: "VoitureId");

            migrationBuilder.CreateIndex(
                name: "IX_Voitures_MarqueId",
                table: "Voitures",
                column: "MarqueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assurances");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Voitures");

            migrationBuilder.DropTable(
                name: "Marques");
        }
    }
}
