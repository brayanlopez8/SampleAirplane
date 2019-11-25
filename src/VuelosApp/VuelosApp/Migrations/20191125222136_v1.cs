using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VuelosApp.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvionesEnt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroSerie = table.Column<int>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Observacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvionesEnt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PasajerosEnt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Identificacion = table.Column<decimal>(nullable: false),
                    Nombres = table.Column<string>(nullable: true),
                    NumeroCelular = table.Column<decimal>(nullable: false),
                    CorreoElectronico = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasajerosEnt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SillasEnt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeroSilla = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SillasEnt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VueloEnt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FechaVuelo = table.Column<DateTime>(nullable: false),
                    Origen = table.Column<string>(nullable: true),
                    Destino = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VueloEnt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VuelosPorPasajeroEnt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdAvion = table.Column<int>(nullable: false),
                    VuelosEntId = table.Column<int>(nullable: true),
                    IdSilla = table.Column<int>(nullable: false),
                    SillasEntId = table.Column<int>(nullable: true),
                    IdVuelo = table.Column<int>(nullable: false),
                    VueloEntId = table.Column<int>(nullable: true),
                    IdPasajero = table.Column<int>(nullable: false),
                    PasajerosEntId = table.Column<int>(nullable: true),
                    FechaCompra = table.Column<DateTime>(nullable: false),
                    FechaAsignacionSilla = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VuelosPorPasajeroEnt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VuelosPorPasajeroEnt_PasajerosEnt_PasajerosEntId",
                        column: x => x.PasajerosEntId,
                        principalTable: "PasajerosEnt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VuelosPorPasajeroEnt_SillasEnt_SillasEntId",
                        column: x => x.SillasEntId,
                        principalTable: "SillasEnt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VuelosPorPasajeroEnt_VueloEnt_VueloEntId",
                        column: x => x.VueloEntId,
                        principalTable: "VueloEnt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VuelosPorPasajeroEnt_AvionesEnt_VuelosEntId",
                        column: x => x.VuelosEntId,
                        principalTable: "AvionesEnt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VuelosPorPasajeroEnt_PasajerosEntId",
                table: "VuelosPorPasajeroEnt",
                column: "PasajerosEntId");

            migrationBuilder.CreateIndex(
                name: "IX_VuelosPorPasajeroEnt_SillasEntId",
                table: "VuelosPorPasajeroEnt",
                column: "SillasEntId");

            migrationBuilder.CreateIndex(
                name: "IX_VuelosPorPasajeroEnt_VueloEntId",
                table: "VuelosPorPasajeroEnt",
                column: "VueloEntId");

            migrationBuilder.CreateIndex(
                name: "IX_VuelosPorPasajeroEnt_VuelosEntId",
                table: "VuelosPorPasajeroEnt",
                column: "VuelosEntId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VuelosPorPasajeroEnt");

            migrationBuilder.DropTable(
                name: "PasajerosEnt");

            migrationBuilder.DropTable(
                name: "SillasEnt");

            migrationBuilder.DropTable(
                name: "VueloEnt");

            migrationBuilder.DropTable(
                name: "AvionesEnt");
        }
    }
}
