using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.DAL.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "ZipCode");

            migrationBuilder.AddColumn<int>(
                name: "PremadePizzaID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SizeID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SizeID",
                table: "OrderDetails",
                column: "SizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Sizes_SizeID",
                table: "OrderDetails",
                column: "SizeID",
                principalTable: "Sizes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Sizes_SizeID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerID",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_SizeID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "PremadePizzaID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "SizeID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "Customers",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
