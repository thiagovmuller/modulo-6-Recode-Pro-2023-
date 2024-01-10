using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace modulo6api.Migrations
{
    public partial class primeiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    dataNasc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idCliente);
                });

            migrationBuilder.CreateTable(
                name: "Passagem",
                columns: table => new
                {
                    idPassagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ciaAerea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    origem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagem", x => x.idPassagem);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    idCompra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    formaPgto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valorTotal = table.Column<double>(type: "float", nullable: false),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    clienteidCliente = table.Column<int>(type: "int", nullable: true),
                    idPassagem = table.Column<int>(type: "int", nullable: false),
                    passagemidPassagem = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.idCompra);
                    table.ForeignKey(
                        name: "FK_Compra_Cliente_clienteidCliente",
                        column: x => x.clienteidCliente,
                        principalTable: "Cliente",
                        principalColumn: "idCliente");
                    table.ForeignKey(
                        name: "FK_Compra_Passagem_passagemidPassagem",
                        column: x => x.passagemidPassagem,
                        principalTable: "Passagem",
                        principalColumn: "idPassagem");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_clienteidCliente",
                table: "Compra",
                column: "clienteidCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_passagemidPassagem",
                table: "Compra",
                column: "passagemidPassagem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Passagem");
        }
    }
}
