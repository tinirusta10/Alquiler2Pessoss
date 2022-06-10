using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alquiler2Pesoss.Migrations
{
    public partial class tablaproducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {



            migrationBuilder.CreateTable(
                name: "TablaPrpducto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProducto = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PrecioProducto = table.Column<float>(type: "real", maxLength: 20, nullable: false),
                    DetallesProducto = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    FotoProducto = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaPrpducto", x => x.Id);
                });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
  

            migrationBuilder.DropTable(
                name: "TablaPrpducto");

          
        }
    }
}
