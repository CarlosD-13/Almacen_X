using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Almacen_X_.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<string>(type: "varchar(15)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(30)", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(30)", nullable: true),
                    Direccion = table.Column<string>(type: "varchar(50)", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(12)", nullable: false),
                    Genero = table.Column<string>(type: "Varchar(1)", nullable: true),
                    Correo = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
