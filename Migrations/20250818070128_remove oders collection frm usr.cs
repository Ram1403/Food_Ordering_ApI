using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Food_Ordering_ApI.Migrations
{
    /// <inheritdoc />
    public partial class removeoderscollectionfrmusr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_menuItems_MenuItemId",
                table: "orderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_orderItems_orders_OrderId",
                table: "orderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_DeliveryPartners_DeliveryPartnerId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_Users_CustomerId",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderItems",
                table: "orderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_menuItems",
                table: "menuItems");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "orderItems",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "menuItems",
                newName: "MenuItems");

            migrationBuilder.RenameIndex(
                name: "IX_orders_DeliveryPartnerId",
                table: "Orders",
                newName: "IX_Orders_DeliveryPartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_orderItems_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_orderItems_MenuItemId",
                table: "OrderItems",
                newName: "IX_OrderItems_MenuItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "OrderItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MenuItems",
                table: "MenuItems",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_MenuItems_MenuItemId",
                table: "OrderItems",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "MenuItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DeliveryPartners_DeliveryPartnerId",
                table: "Orders",
                column: "DeliveryPartnerId",
                principalTable: "DeliveryPartners",
                principalColumn: "DeliveryPartnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_MenuItems_MenuItemId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DeliveryPartners_DeliveryPartnerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_CustomerId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MenuItems",
                table: "MenuItems");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "orderItems");

            migrationBuilder.RenameTable(
                name: "MenuItems",
                newName: "menuItems");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DeliveryPartnerId",
                table: "orders",
                newName: "IX_orders_DeliveryPartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "orders",
                newName: "IX_orders_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "orderItems",
                newName: "IX_orderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_MenuItemId",
                table: "orderItems",
                newName: "IX_orderItems_MenuItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderItems",
                table: "orderItems",
                column: "OrderItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_menuItems",
                table: "menuItems",
                column: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_menuItems_MenuItemId",
                table: "orderItems",
                column: "MenuItemId",
                principalTable: "menuItems",
                principalColumn: "MenuItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderItems_orders_OrderId",
                table: "orderItems",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_DeliveryPartners_DeliveryPartnerId",
                table: "orders",
                column: "DeliveryPartnerId",
                principalTable: "DeliveryPartners",
                principalColumn: "DeliveryPartnerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_Users_CustomerId",
                table: "orders",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
