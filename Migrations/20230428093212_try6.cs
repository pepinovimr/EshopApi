using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EshopApi.Migrations
{
    /// <inheritdoc />
    public partial class try6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PurchaserOrderId",
                table: "PurchaseOrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaserOrderId",
                table: "PurchaseOrderItems");
        }
    }
}
