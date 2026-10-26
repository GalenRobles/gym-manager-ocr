using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace gymmanagerocr.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CortesCaja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fecha = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VentasInventarioCalculadas = table.Column<decimal>(type: "numeric", nullable: false),
                    IngresoPlanesRegistrado = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalEsperado = table.Column<decimal>(type: "numeric", nullable: false),
                    TotalEntregado = table.Column<decimal>(type: "numeric", nullable: false),
                    Descuadre = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CortesCaja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanesGimnasio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanesGimnasio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Categoria = table.Column<string>(type: "text", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "numeric", nullable: false),
                    StockActual = table.Column<int>(type: "integer", nullable: false),
                    Activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FechaCorte = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PlanGimnasioId = table.Column<int>(type: "integer", nullable: false),
                    CantidadVendida = table.Column<int>(type: "integer", nullable: false),
                    TotalRecaudado = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrosTickets_PlanesGimnasio_PlanGimnasioId",
                        column: x => x.PlanGimnasioId,
                        principalTable: "PlanesGimnasio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrosInventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FechaCorte = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ProductoId = table.Column<int>(type: "integer", nullable: false),
                    InventarioInicial = table.Column<int>(type: "integer", nullable: false),
                    SurtidoCompras = table.Column<int>(type: "integer", nullable: false),
                    InventarioFinal = table.Column<int>(type: "integer", nullable: false),
                    CantidadVendida = table.Column<int>(type: "integer", nullable: false),
                    TotalRecaudado = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrosInventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrosInventario_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosInventario_ProductoId",
                table: "RegistrosInventario",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrosTickets_PlanGimnasioId",
                table: "RegistrosTickets",
                column: "PlanGimnasioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CortesCaja");

            migrationBuilder.DropTable(
                name: "RegistrosInventario");

            migrationBuilder.DropTable(
                name: "RegistrosTickets");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "PlanesGimnasio");
        }
    }
}
