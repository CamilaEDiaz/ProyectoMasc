using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotasApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdopcionItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cod_Personna = table.Column<long>(nullable: false),
                    NombreCompleto = table.Column<string>(nullable: true),
                    Telefono = table.Column<long>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdopcionItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MascotaItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    Raza = table.Column<string>(nullable: true),
                    TipoMascota = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MascotaItems", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdopcionItems");

            migrationBuilder.DropTable(
                name: "MascotaItems");
        }
    }
}
