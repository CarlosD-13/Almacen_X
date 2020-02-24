using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Almacen_X_.Migrations.Empleado
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo_Empleado = table.Column<string>(type: "varchar(10)", nullable: true),
                    Cedula = table.Column<string>(type: "varchar(15)", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(30)", nullable: true),
                    Apellido = table.Column<string>(type: "varchar(30)", nullable: true),
                    Fecha_Ingreso = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Ocupacion = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
