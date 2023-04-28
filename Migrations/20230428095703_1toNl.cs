using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EshopApi.Migrations
{
    /// <inheritdoc />
    public partial class _1toNl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_PurchaserOrderId",
                table: "PurchaseOrderItems",
                column: "PurchaserOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaserOrderId",
                table: "PurchaseOrderItems",
                column: "PurchaserOrderId",
                principalTable: "PurchaseOrderHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaserOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrderItems_PurchaserOrderId",
                table: "PurchaseOrderItems");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderId",
                table: "PurchaseOrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrderItems_PurchaseOrderId",
                table: "PurchaseOrderItems",
                column: "PurchaseOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrderItems_PurchaseOrderHeaders_PurchaseOrderId",
                table: "PurchaseOrderItems",
                column: "PurchaseOrderId",
                principalTable: "PurchaseOrderHeaders",
                principalColumn: "Id");
        }
    }
}
