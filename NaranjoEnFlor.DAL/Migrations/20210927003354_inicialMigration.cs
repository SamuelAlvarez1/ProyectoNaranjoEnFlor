using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NaranjoEnFlor.DAL.Migrations
{
    public partial class inicialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mesas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "metodosPago",
                columns: table => new
                {
                    IdMetodoPago = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_metodosPago", x => x.IdMetodoPago);
                });

            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    MetodoPagoIdMetodoPago = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_facturas_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_facturas_metodosPago_MetodoPagoIdMetodoPago",
                        column: x => x.MetodoPagoIdMetodoPago,
                        principalTable: "metodosPago",
                        principalColumn: "IdMetodoPago",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Cantidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    Facturacodigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.IdProducto);
                    table.ForeignKey(
                        name: "FK_productos_facturas_Facturacodigo",
                        column: x => x.Facturacodigo,
                        principalTable: "facturas",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "metodosPago",
                columns: new[] { "IdMetodoPago", "Estado", "nombre" },
                values: new object[] { 1, false, "Efectivo" });

            migrationBuilder.InsertData(
                table: "metodosPago",
                columns: new[] { "IdMetodoPago", "Estado", "nombre" },
                values: new object[] { 2, false, "transferencia" });

            migrationBuilder.CreateIndex(
                name: "IX_facturas_ClienteId",
                table: "facturas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_facturas_MetodoPagoIdMetodoPago",
                table: "facturas",
                column: "MetodoPagoIdMetodoPago");

            migrationBuilder.CreateIndex(
                name: "IX_productos_Facturacodigo",
                table: "productos",
                column: "Facturacodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mesas");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "facturas");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "metodosPago");
        }
    }
}
