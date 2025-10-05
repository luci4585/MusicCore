using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ModelosActualizados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "Precio" },
                values: new object[] { new DateTime(2025, 10, 5, 15, 38, 3, 166, DateTimeKind.Local).AddTicks(2611), 10000m });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cantidad", "Fecha", "Precio" },
                values: new object[] { 3, new DateTime(2025, 10, 5, 15, 38, 3, 166, DateTimeKind.Local).AddTicks(2625), 12000m });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cantidad", "Fecha", "Precio" },
                values: new object[] { 5, new DateTime(2025, 10, 5, 15, 38, 3, 166, DateTimeKind.Local).AddTicks(2627), 15000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "Precio" },
                values: new object[] { new DateTime(2025, 10, 3, 16, 36, 40, 734, DateTimeKind.Local).AddTicks(2261), 19.99m });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cantidad", "Fecha", "Precio" },
                values: new object[] { 1, new DateTime(2025, 10, 3, 16, 36, 40, 734, DateTimeKind.Local).AddTicks(2272), 9.99m });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cantidad", "Fecha", "Precio" },
                values: new object[] { 1, new DateTime(2025, 10, 3, 16, 36, 40, 734, DateTimeKind.Local).AddTicks(2274), 14.99m });
        }
    }
}
