using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ContaRepository.Migrations
{
    public partial class ImovelMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "imovelid",
                table: "contas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Imoveis",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Identificacao = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imoveis", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contas_imovelid",
                table: "contas",
                column: "imovelid");

            migrationBuilder.AddForeignKey(
                name: "FK_contas_Imoveis_imovelid",
                table: "contas",
                column: "imovelid",
                principalTable: "Imoveis",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contas_Imoveis_imovelid",
                table: "contas");

            migrationBuilder.DropTable(
                name: "Imoveis");

            migrationBuilder.DropIndex(
                name: "IX_contas_imovelid",
                table: "contas");

            migrationBuilder.DropColumn(
                name: "imovelid",
                table: "contas");
        }
    }
}
