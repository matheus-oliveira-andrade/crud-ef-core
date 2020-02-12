using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreCRUD.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar", maxLength: 60, nullable: false),
                    Idade = table.Column<int>(type: "integer", nullable: false),
                    Endereco = table.Column<string>(type: "varchar", maxLength: 1000, nullable: false),
                    Email = table.Column<string>(type: "varchar", maxLength: 30, nullable: false),
                    Telefone = table.Column<string>(type: "varchar", maxLength: 20, nullable: false),
                    InfoComplentares = table.Column<string>(type: "varchar", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
