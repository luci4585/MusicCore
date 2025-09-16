using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class AjustesdeId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Discos_DiscoId",
                table: "Ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Ventas_DiscoId",
                table: "Ventas");

            migrationBuilder.DeleteData(
                table: "Ventas",
                keyColumn: "VentaId",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ventas",
                keyColumn: "VentaId",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ventas",
                keyColumn: "VentaId",
                keyColumnType: "int",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "VentaId",
                table: "Ventas");

            migrationBuilder.RenameColumn(
                name: "DiscoId",
                table: "Ventas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GeneroId",
                table: "Generos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DiscoId",
                table: "Discos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CancionId",
                table: "Canciones",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArtistaId",
                table: "Artistas",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Ventas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DiscoVenta",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "int", nullable: false),
                    DiscoId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscoVenta", x => new { x.VentaId, x.DiscoId });
                    table.ForeignKey(
                        name: "FK_DiscoVenta_Discos_DiscoId",
                        column: x => x.DiscoId,
                        principalTable: "Discos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiscoVenta_Ventas_VentaId",
                        column: x => x.VentaId,
                        principalTable: "Ventas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "Id", "Cantidad", "ClienteId", "Fecha", "IsDeleted", "Precio" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2025, 9, 16, 17, 50, 14, 568, DateTimeKind.Local).AddTicks(1662), false, 95000m },
                    { 2, 2, 2, new DateTime(2025, 9, 16, 17, 50, 14, 568, DateTimeKind.Local).AddTicks(1683), false, 70000m },
                    { 3, 1, 3, new DateTime(2025, 9, 16, 17, 50, 14, 568, DateTimeKind.Local).AddTicks(1686), false, 80000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DiscoVenta_DiscoId",
                table: "DiscoVenta",
                column: "DiscoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiscoVenta");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas");

            migrationBuilder.DeleteData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ventas",
                newName: "DiscoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Generos",
                newName: "GeneroId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Discos",
                newName: "DiscoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Canciones",
                newName: "CancionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Artistas",
                newName: "ArtistaId");

            migrationBuilder.AlterColumn<int>(
                name: "DiscoId",
                table: "Ventas",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "VentaId",
                table: "Ventas",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas",
                column: "VentaId");

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
                name: "IX_Ventas_DiscoId",
                table: "Ventas",
                column: "DiscoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Discos_DiscoId",
                table: "Ventas",
                column: "DiscoId",
                principalTable: "Discos",
                principalColumn: "DiscoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
