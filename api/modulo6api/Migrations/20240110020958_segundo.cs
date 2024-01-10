using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace modulo6api.Migrations
{
    public partial class segundo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Cliente_clienteidCliente",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Passagem_passagemidPassagem",
                table: "Compra");

            migrationBuilder.RenameColumn(
                name: "valor",
                table: "Passagem",
                newName: "Valor");

            migrationBuilder.RenameColumn(
                name: "origem",
                table: "Passagem",
                newName: "Origem");

            migrationBuilder.RenameColumn(
                name: "destino",
                table: "Passagem",
                newName: "Destino");

            migrationBuilder.RenameColumn(
                name: "ciaAerea",
                table: "Passagem",
                newName: "CiaAerea");

            migrationBuilder.RenameColumn(
                name: "idPassagem",
                table: "Passagem",
                newName: "IdPassagem");

            migrationBuilder.RenameColumn(
                name: "valorTotal",
                table: "Compra",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "passagemidPassagem",
                table: "Compra",
                newName: "PassagemIdPassagem");

            migrationBuilder.RenameColumn(
                name: "idPassagem",
                table: "Compra",
                newName: "IdPassagem");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Compra",
                newName: "IdCliente");

            migrationBuilder.RenameColumn(
                name: "formaPgto",
                table: "Compra",
                newName: "FormaPgto");

            migrationBuilder.RenameColumn(
                name: "clienteidCliente",
                table: "Compra",
                newName: "ClienteIdCliente");

            migrationBuilder.RenameColumn(
                name: "idCompra",
                table: "Compra",
                newName: "IdCompra");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_passagemidPassagem",
                table: "Compra",
                newName: "IX_Compra_PassagemIdPassagem");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_clienteidCliente",
                table: "Compra",
                newName: "IX_Compra_ClienteIdCliente");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Cliente",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Cliente",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "dataNasc",
                table: "Cliente",
                newName: "DataNasc");

            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Cliente",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Cliente",
                newName: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Cliente_ClienteIdCliente",
                table: "Compra",
                column: "ClienteIdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Passagem_PassagemIdPassagem",
                table: "Compra",
                column: "PassagemIdPassagem",
                principalTable: "Passagem",
                principalColumn: "IdPassagem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Cliente_ClienteIdCliente",
                table: "Compra");

            migrationBuilder.DropForeignKey(
                name: "FK_Compra_Passagem_PassagemIdPassagem",
                table: "Compra");

            migrationBuilder.RenameColumn(
                name: "Valor",
                table: "Passagem",
                newName: "valor");

            migrationBuilder.RenameColumn(
                name: "Origem",
                table: "Passagem",
                newName: "origem");

            migrationBuilder.RenameColumn(
                name: "Destino",
                table: "Passagem",
                newName: "destino");

            migrationBuilder.RenameColumn(
                name: "CiaAerea",
                table: "Passagem",
                newName: "ciaAerea");

            migrationBuilder.RenameColumn(
                name: "IdPassagem",
                table: "Passagem",
                newName: "idPassagem");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "Compra",
                newName: "valorTotal");

            migrationBuilder.RenameColumn(
                name: "PassagemIdPassagem",
                table: "Compra",
                newName: "passagemidPassagem");

            migrationBuilder.RenameColumn(
                name: "IdPassagem",
                table: "Compra",
                newName: "idPassagem");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Compra",
                newName: "idCliente");

            migrationBuilder.RenameColumn(
                name: "FormaPgto",
                table: "Compra",
                newName: "formaPgto");

            migrationBuilder.RenameColumn(
                name: "ClienteIdCliente",
                table: "Compra",
                newName: "clienteidCliente");

            migrationBuilder.RenameColumn(
                name: "IdCompra",
                table: "Compra",
                newName: "idCompra");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_PassagemIdPassagem",
                table: "Compra",
                newName: "IX_Compra_passagemidPassagem");

            migrationBuilder.RenameIndex(
                name: "IX_Compra_ClienteIdCliente",
                table: "Compra",
                newName: "IX_Compra_clienteidCliente");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Cliente",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Cliente",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "DataNasc",
                table: "Cliente",
                newName: "dataNasc");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Cliente",
                newName: "cpf");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Cliente",
                newName: "idCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Cliente_clienteidCliente",
                table: "Compra",
                column: "clienteidCliente",
                principalTable: "Cliente",
                principalColumn: "idCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_Passagem_passagemidPassagem",
                table: "Compra",
                column: "passagemidPassagem",
                principalTable: "Passagem",
                principalColumn: "idPassagem");
        }
    }
}
