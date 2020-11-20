using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMvcApp.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Pizzerias",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlLogo",
                table: "Pizzerias",
                type: "longtext",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Pizzerias");

            migrationBuilder.DropColumn(
                name: "UrlLogo",
                table: "Pizzerias");
        }
    }
}
