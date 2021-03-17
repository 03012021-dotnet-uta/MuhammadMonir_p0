using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.DAL.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomizedPizzaToppings");

            migrationBuilder.DropTable(
                name: "PremadePizzaToppings");

            migrationBuilder.AddColumn<int>(
                name: "ToppingID",
                table: "PremadePizzas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToppingID",
                table: "CustomizedPizzas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomizedPizzaTopping",
                columns: table => new
                {
                    CustomizedPizzaID = table.Column<int>(type: "int", nullable: false),
                    ToppingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomizedPizzaTopping", x => new { x.CustomizedPizzaID, x.ToppingID });
                    table.ForeignKey(
                        name: "FK_CustomizedPizzaTopping_CustomizedPizzas_CustomizedPizzaID",
                        column: x => x.CustomizedPizzaID,
                        principalTable: "CustomizedPizzas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomizedPizzaTopping_Toppings_ToppingID",
                        column: x => x.ToppingID,
                        principalTable: "Toppings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PremadePizzaTopping",
                columns: table => new
                {
                    PremadePizzaID = table.Column<int>(type: "int", nullable: false),
                    ToppingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremadePizzaTopping", x => new { x.PremadePizzaID, x.ToppingID });
                    table.ForeignKey(
                        name: "FK_PremadePizzaTopping_PremadePizzas_PremadePizzaID",
                        column: x => x.PremadePizzaID,
                        principalTable: "PremadePizzas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PremadePizzaTopping_Toppings_ToppingID",
                        column: x => x.ToppingID,
                        principalTable: "Toppings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PremadePizzas_ToppingID",
                table: "PremadePizzas",
                column: "ToppingID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomizedPizzas_ToppingID",
                table: "CustomizedPizzas",
                column: "ToppingID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomizedPizzaTopping_ToppingID",
                table: "CustomizedPizzaTopping",
                column: "ToppingID");

            migrationBuilder.CreateIndex(
                name: "IX_PremadePizzaTopping_ToppingID",
                table: "PremadePizzaTopping",
                column: "ToppingID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomizedPizzas_Toppings_ToppingID",
                table: "CustomizedPizzas",
                column: "ToppingID",
                principalTable: "Toppings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PremadePizzas_Toppings_ToppingID",
                table: "PremadePizzas",
                column: "ToppingID",
                principalTable: "Toppings",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomizedPizzas_Toppings_ToppingID",
                table: "CustomizedPizzas");

            migrationBuilder.DropForeignKey(
                name: "FK_PremadePizzas_Toppings_ToppingID",
                table: "PremadePizzas");

            migrationBuilder.DropTable(
                name: "CustomizedPizzaTopping");

            migrationBuilder.DropTable(
                name: "PremadePizzaTopping");

            migrationBuilder.DropIndex(
                name: "IX_PremadePizzas_ToppingID",
                table: "PremadePizzas");

            migrationBuilder.DropIndex(
                name: "IX_CustomizedPizzas_ToppingID",
                table: "CustomizedPizzas");

            migrationBuilder.DropColumn(
                name: "ToppingID",
                table: "PremadePizzas");

            migrationBuilder.DropColumn(
                name: "ToppingID",
                table: "CustomizedPizzas");

            migrationBuilder.CreateTable(
                name: "CustomizedPizzaToppings",
                columns: table => new
                {
                    CustomizedPizzasID = table.Column<int>(type: "int", nullable: false),
                    ToppingsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomizedPizzaToppings", x => new { x.CustomizedPizzasID, x.ToppingsID });
                    table.ForeignKey(
                        name: "FK_CustomizedPizzaToppings_CustomizedPizzas_CustomizedPizzasID",
                        column: x => x.CustomizedPizzasID,
                        principalTable: "CustomizedPizzas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomizedPizzaToppings_Toppings_ToppingsID",
                        column: x => x.ToppingsID,
                        principalTable: "Toppings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PremadePizzaToppings",
                columns: table => new
                {
                    PremadePizzaToppingsID = table.Column<int>(type: "int", nullable: false),
                    ToppingsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PremadePizzaToppings", x => new { x.PremadePizzaToppingsID, x.ToppingsID });
                    table.ForeignKey(
                        name: "FK_PremadePizzaToppings_PremadePizzas_PremadePizzaToppingsID",
                        column: x => x.PremadePizzaToppingsID,
                        principalTable: "PremadePizzas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PremadePizzaToppings_Toppings_ToppingsID",
                        column: x => x.ToppingsID,
                        principalTable: "Toppings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomizedPizzaToppings_ToppingsID",
                table: "CustomizedPizzaToppings",
                column: "ToppingsID");

            migrationBuilder.CreateIndex(
                name: "IX_PremadePizzaToppings_ToppingsID",
                table: "PremadePizzaToppings",
                column: "ToppingsID");
        }
    }
}
