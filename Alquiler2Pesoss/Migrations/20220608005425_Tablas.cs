using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alquiler2Pesoss.Migrations
{
    public partial class Tablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablaDepartamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaDepartamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaLocalidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreLocalidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaLocalidad", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaProvincia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProvincia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaProvincia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaTipoDocumento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaTipoDocumento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaDepartamento");

            migrationBuilder.DropTable(
                name: "TablaLocalidad");

            migrationBuilder.DropTable(
                name: "TablaProvincia");

            migrationBuilder.DropTable(
                name: "TablaTipoDocumento");
        }
    }
}
