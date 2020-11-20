using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMvcApp.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PizzeriaID",
                table: "Pizzas",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_PizzeriaID",
                table: "Pizzas",
                column: "PizzeriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pizzas_Pizzerias_PizzeriaID",
                table: "Pizzas",
                column: "PizzeriaID",
                principalTable: "Pizzerias",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pizzas_Pizzerias_PizzeriaID",
                table: "Pizzas");

            migrationBuilder.DropIndex(
                name: "IX_Pizzas_PizzeriaID",
                table: "Pizzas");

            migrationBuilder.DropColumn(
                name: "PizzeriaID",
                table: "Pizzas");
        }
    }
}
