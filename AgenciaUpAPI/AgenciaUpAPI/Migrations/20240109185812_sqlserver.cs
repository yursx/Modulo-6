using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgenciaUpAPI.Migrations
{
    public partial class sqlserver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    Id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    CPF = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.Id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passagens",
                columns: table => new
                {
                    Id_passagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_cliente = table.Column<int>(type: "int", nullable: false),
                    Saida_viagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino_viagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_viagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagens", x => x.Id_passagem);
                });

            migrationBuilder.CreateTable(
                name: "ClientesPassagens",
                columns: table => new
                {
                    ClientesId = table.Column<int>(type: "int", nullable: false),
                    PassagensId_passagem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesPassagens", x => new { x.ClientesId, x.PassagensId_passagem });
                    table.ForeignKey(
                        name: "FK_ClientesPassagens_Clientes_ClientesId",
                        column: x => x.ClientesId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesPassagens_Passagens_PassagensId_passagem",
                        column: x => x.PassagensId_passagem,
                        principalTable: "Passagens",
                        principalColumn: "Id_passagem",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientesPassagens_PassagensId_passagem",
                table: "ClientesPassagens",
                column: "PassagensId_passagem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastro");

            migrationBuilder.DropTable(
                name: "ClientesPassagens");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Passagens");
        }
    }
}
