using Microsoft.EntityFrameworkCore.Migrations;

namespace GestionEmpleados.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    CodEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    primerNombre = table.Column<string>(type: "varchar (150)", nullable: false),
                    segundoNomre = table.Column<string>(type: "varchar (150)", nullable: false),
                    primerApellido = table.Column<string>(type: "varchar (150)", nullable: false),
                    segundoApellido = table.Column<string>(type: "varchar (150)", nullable: false),
                    Cedula = table.Column<string>(type: "varchar (12)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.CodEmpleado);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
