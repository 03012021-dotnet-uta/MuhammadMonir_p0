using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.DAL.Migrations
{
    public partial class sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomizedPizzaID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreID",
                table: "Orders",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_CustomizedPizzaID",
                table: "OrderDetails",
                column: "CustomizedPizzaID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PremadePizzaID",
                table: "OrderDetails",
                column: "PremadePizzaID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_CustomizedPizzas_CustomizedPizzaID",
                table: "OrderDetails",
                column: "CustomizedPizzaID",
                principalTable: "CustomizedPizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_PremadePizzas_PremadePizzaID",
                table: "OrderDetails",
                column: "PremadePizzaID",
                principalTable: "PremadePizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreID",
                table: "Orders",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_CustomizedPizzas_CustomizedPizzaID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_PremadePizzas_PremadePizzaID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_StoreID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_CustomizedPizzaID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_PremadePizzaID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "CustomizedPizzaID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "OrderDetails");
        }
    }
}
