using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alquiler2Pesoss.Migrations
{
    public partial class tablapersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablaPersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    RepetirContraseña = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumeroTelefono = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    IdTipoDocumento = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    IdProvincia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Piso = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    IdDepartamento = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    calle = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Depto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IdLocalidad = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Altura = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    CP = table.Column<int>(type: "int", maxLength: 25, nullable: false),
                    Referencia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaPersona", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "personassDNI_UQ",
                table: "TablaPersona",
                column: "DNI",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablaPersona");
        }
    }
}
