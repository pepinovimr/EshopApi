using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EshopApi.Migrations
{
    /// <inheritdoc />
    public partial class _1toNrev : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderHeaders_PurchaseOrderItems_PurchaseOrderItemsId",
                table: "PurchaseOrderHeaders");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderHeaders_PurchaseOrderItemsId",
                table: "PurchaseOrderHeaders");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderItemsId",
                table: "PurchaseOrderHeaders");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderHeadersId",
                table: "PurchaseOrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrderHeadersId",
                table: "PurchaseOrderItems",
                column: "PurchaseOrderHeadersId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaseOrderHeadersId",
                table: "PurchaseOrderItems",
                column: "PurchaseOrderHeadersId",
                principalTable: "PurchaseOrderHeaders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaseOrderHeadersId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrderHeadersId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderHeadersId",
                table: "PurchaseOrderItems");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderItemsId",
                table: "PurchaseOrderHeaders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderHeaders_PurchaseOrderItemsId",
                table: "PurchaseOrderHeaders",
                column: "PurchaseOrderItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderHeaders_PurchaseOrderItems_PurchaseOrderItemsId",
                table: "PurchaseOrderHeaders",
                column: "PurchaseOrderItemsId",
                principalTable: "PurchaseOrderItems",
                principalColumn: "Id");
        }
    }
}
