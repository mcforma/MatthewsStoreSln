using Microsoft.EntityFrameworkCore.Migrations;

namespace OutdoorProducts.Migrations
{
    public partial class ShippedOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLine_orders_OrderID",
                table: "CartLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.AddColumn<bool>(
                name: "Shipped",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartLine_Orders_OrderID",
                table: "CartLine",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartLine_Orders_OrderID",
                table: "CartLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Shipped",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CartLine_orders_OrderID",
                table: "CartLine",
                column: "OrderID",
                principalTable: "orders",
                principalColumn: "OrderID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
