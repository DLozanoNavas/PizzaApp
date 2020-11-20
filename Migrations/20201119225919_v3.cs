using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMvcApp.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Pizzas",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagenUrl",
                table: "Pizzas",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Menus",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagenUrl",
                table: "Menus",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Menus",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Ingredientes",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagenUrl",
                table: "Ingredientes",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Bebidas",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagenUrl",
                table: "Bebidas",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Adicionales",
                type: "longtext",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagenUrl",
                table: "Adicionales",
                type: "longtext",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "ImagenUrl",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "ImagenUrl",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Ingredientes");

            migrationBuilder.DropColumn(
                name: "ImagenUrl",
                table: "Ingredientes");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Bebidas");

            migrationBuilder.DropColumn(
                name: "ImagenUrl",
                table: "Bebidas");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Adicionales");

            migrationBuilder.DropColumn(
                name: "ImagenUrl",
                table: "Adicionales");
        }
    }
}
