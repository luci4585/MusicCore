using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Artistas",
                columns: table => new
                {
                    ArtistaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.ArtistaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    GeneroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.GeneroId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Discos",
                columns: table => new
                {
                    DiscoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ArtistaId = table.Column<int>(type: "int", nullable: false),
                    GeneroId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discos", x => x.DiscoId);
                    table.ForeignKey(
                        name: "FK_Discos_Artistas_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artistas",
                        principalColumn: "ArtistaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Discos_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Generos",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Canciones",
                columns: table => new
                {
                    CancionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titulo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Duracion = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DiscoId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canciones", x => x.CancionId);
                    table.ForeignKey(
                        name: "FK_Canciones_Discos_DiscoId",
                        column: x => x.DiscoId,
                        principalTable: "Discos",
                        principalColumn: "DiscoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    DiscoId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                    table.ForeignKey(
                        name: "FK_Ventas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Discos_DiscoId",
                        column: x => x.DiscoId,
                        principalTable: "Discos",
                        principalColumn: "DiscoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Artistas",
                columns: new[] { "ArtistaId", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "The Beatles" },
                    { 2, false, "Michael Jackson" },
                    { 3, false, "Madonna" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Email", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, "perezJuan@gmail.com", false, "Juan Perez" },
                    { 2, "gomezMaria@gmail.com", false, "Maria Gomez" },
                    { 3, "sanchezCarlos@gmail.com", false, "Carlos Sanchez" }
                });

            migrationBuilder.InsertData(
                table: "Generos",
                columns: new[] { "GeneroId", "IsDeleted", "Nombre" },
                values: new object[,]
                {
                    { 1, false, "Rock" },
                    { 2, false, "Pop" },
                    { 3, false, "Jazz" }
                });

            migrationBuilder.InsertData(
                table: "Discos",
                columns: new[] { "DiscoId", "ArtistaId", "GeneroId", "IsDeleted", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, 1, false, "Abbey Road" },
                    { 2, 2, 2, false, "Thriller" },
                    { 3, 3, 2, false, "Like a Virgin" }
                });

            migrationBuilder.InsertData(
                table: "Canciones",
                columns: new[] { "CancionId", "DiscoId", "Duracion", "IsDeleted", "Titulo" },
                values: new object[,]
                {
                    { 1, 1, 4.20m, false, "Come Together" },
                    { 2, 2, 4.54m, false, "Billie Jean" },
                    { 3, 3, 4.00m, false, "Material Girl" }
                });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "VentaId", "Cantidad", "ClienteId", "DiscoId", "Fecha", "IsDeleted", "Precio" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, new DateTime(2025, 8, 24, 16, 45, 11, 40, DateTimeKind.Local).AddTicks(9975), false, 95000m },
                    { 2, 2, 2, 2, new DateTime(2025, 8, 24, 16, 45, 11, 40, DateTimeKind.Local).AddTicks(9989), false, 70000m },
                    { 3, 1, 3, 3, new DateTime(2025, 8, 24, 16, 45, 11, 40, DateTimeKind.Local).AddTicks(9991), false, 80000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Canciones_DiscoId",
                table: "Canciones",
                column: "DiscoId");

            migrationBuilder.CreateIndex(
                name: "IX_Discos_ArtistaId",
                table: "Discos",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Discos_GeneroId",
                table: "Discos",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ClienteId",
                table: "Ventas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_DiscoId",
                table: "Ventas",
                column: "DiscoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Canciones");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Discos");

            migrationBuilder.DropTable(
                name: "Artistas");

            migrationBuilder.DropTable(
                name: "Generos");
        }
    }
}
