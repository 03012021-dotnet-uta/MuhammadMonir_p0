using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.DAL.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomizedPizzaTopping_CustomizedPizzas_CustomizedPizzasID",
                table: "CustomizedPizzaTopping");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomizedPizzaTopping_Toppings_ToppingsID",
                table: "CustomizedPizzaTopping");

            migrationBuilder.DropForeignKey(
                name: "FK_PremadePizzaTopping_PremadePizzas_PremadePizzaToppingsID",
                table: "PremadePizzaTopping");

            migrationBuilder.DropForeignKey(
                name: "FK_PremadePizzaTopping_Toppings_ToppingsID",
                table: "PremadePizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PremadePizzaTopping",
                table: "PremadePizzaTopping");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomizedPizzaTopping",
                table: "CustomizedPizzaTopping");

            migrationBuilder.RenameTable(
                name: "PremadePizzaTopping",
                newName: "PremadePizzaToppings");

            migrationBuilder.RenameTable(
                name: "CustomizedPizzaTopping",
                newName: "CustomizedPizzaToppings");

            migrationBuilder.RenameIndex(
                name: "IX_PremadePizzaTopping_ToppingsID",
                table: "PremadePizzaToppings",
                newName: "IX_PremadePizzaToppings_ToppingsID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomizedPizzaTopping_ToppingsID",
                table: "CustomizedPizzaToppings",
                newName: "IX_CustomizedPizzaToppings_ToppingsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PremadePizzaToppings",
                table: "PremadePizzaToppings",
                columns: new[] { "PremadePizzaToppingsID", "ToppingsID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomizedPizzaToppings",
                table: "CustomizedPizzaToppings",
                columns: new[] { "CustomizedPizzasID", "ToppingsID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomizedPizzaToppings_CustomizedPizzas_CustomizedPizzasID",
                table: "CustomizedPizzaToppings",
                column: "CustomizedPizzasID",
                principalTable: "CustomizedPizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomizedPizzaToppings_Toppings_ToppingsID",
                table: "CustomizedPizzaToppings",
                column: "ToppingsID",
                principalTable: "Toppings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PremadePizzaToppings_PremadePizzas_PremadePizzaToppingsID",
                table: "PremadePizzaToppings",
                column: "PremadePizzaToppingsID",
                principalTable: "PremadePizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PremadePizzaToppings_Toppings_ToppingsID",
                table: "PremadePizzaToppings",
                column: "ToppingsID",
                principalTable: "Toppings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomizedPizzaToppings_CustomizedPizzas_CustomizedPizzasID",
                table: "CustomizedPizzaToppings");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomizedPizzaToppings_Toppings_ToppingsID",
                table: "CustomizedPizzaToppings");

            migrationBuilder.DropForeignKey(
                name: "FK_PremadePizzaToppings_PremadePizzas_PremadePizzaToppingsID",
                table: "PremadePizzaToppings");

            migrationBuilder.DropForeignKey(
                name: "FK_PremadePizzaToppings_Toppings_ToppingsID",
                table: "PremadePizzaToppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PremadePizzaToppings",
                table: "PremadePizzaToppings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomizedPizzaToppings",
                table: "CustomizedPizzaToppings");

            migrationBuilder.RenameTable(
                name: "PremadePizzaToppings",
                newName: "PremadePizzaTopping");

            migrationBuilder.RenameTable(
                name: "CustomizedPizzaToppings",
                newName: "CustomizedPizzaTopping");

            migrationBuilder.RenameIndex(
                name: "IX_PremadePizzaToppings_ToppingsID",
                table: "PremadePizzaTopping",
                newName: "IX_PremadePizzaTopping_ToppingsID");

            migrationBuilder.RenameIndex(
                name: "IX_CustomizedPizzaToppings_ToppingsID",
                table: "CustomizedPizzaTopping",
                newName: "IX_CustomizedPizzaTopping_ToppingsID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PremadePizzaTopping",
                table: "PremadePizzaTopping",
                columns: new[] { "PremadePizzaToppingsID", "ToppingsID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomizedPizzaTopping",
                table: "CustomizedPizzaTopping",
                columns: new[] { "CustomizedPizzasID", "ToppingsID" });

            migrationBuilder.AddForeignKey(
                name: "FK_CustomizedPizzaTopping_CustomizedPizzas_CustomizedPizzasID",
                table: "CustomizedPizzaTopping",
                column: "CustomizedPizzasID",
                principalTable: "CustomizedPizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomizedPizzaTopping_Toppings_ToppingsID",
                table: "CustomizedPizzaTopping",
                column: "ToppingsID",
                principalTable: "Toppings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PremadePizzaTopping_PremadePizzas_PremadePizzaToppingsID",
                table: "PremadePizzaTopping",
                column: "PremadePizzaToppingsID",
                principalTable: "PremadePizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PremadePizzaTopping_Toppings_ToppingsID",
                table: "PremadePizzaTopping",
                column: "ToppingsID",
                principalTable: "Toppings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
