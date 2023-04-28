using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EshopApi.Migrations
{
    /// <inheritdoc />
    public partial class _1toNre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaseOrderHeadersId",
                table: "PurchaseOrderItems");

            migrationBuilder.RenameColumn(
                name: "PurchaseOrderHeadersId",
                table: "PurchaseOrderItems",
                newName: "PurchaseOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrderHeadersId",
                table: "PurchaseOrderItems",
                newName: "IX_PurchaseOrderItems_PurchaseOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaseOrderId",
                table: "PurchaseOrderItems",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrderHeaders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.RenameColumn(
                name: "PurchaseOrderId",
                table: "PurchaseOrderItems",
                newName: "PurchaseOrderHeadersId");

            migrationBuilder.RenameIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrderId",
                table: "PurchaseOrderItems",
                newName: "IX_PurchaseOrderItems_PurchaseOrderHeadersId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaseOrderHeadersId",
                table: "PurchaseOrderItems",
                column: "PurchaseOrderHeadersId",
                principalTable: "PurchaseOrderHeaders",
                principalColumn: "Id");
        }
    }
}
