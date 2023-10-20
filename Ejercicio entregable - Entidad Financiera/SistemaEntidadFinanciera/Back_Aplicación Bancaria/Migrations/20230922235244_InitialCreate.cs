using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Back_Aplicación_Bancaria.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DNI = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_Cuenta = table.Column<int>(type: "int", nullable: false),
                    saldo = table.Column<double>(type: "float", nullable: false),
                    tipo_cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueñoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuentas_Clientes_DueñoId",
                        column: x => x.DueñoId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarjetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroTarjeta = table.Column<int>(type: "int", nullable: false),
                    limiteCredito = table.Column<int>(type: "int", nullable: false),
                    saldoDisponible = table.Column<double>(type: "float", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontoDeuda = table.Column<double>(type: "float", nullable: false),
                    DueñoTarjetaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarjetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarjetas_Clientes_DueñoTarjetaId",
                        column: x => x.DueñoTarjetaId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_DueñoId",
                table: "Cuentas",
                column: "DueñoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarjetas_DueñoTarjetaId",
                table: "Tarjetas",
                column: "DueñoTarjetaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "Tarjetas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
