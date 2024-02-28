﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DominosStockOrder.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedInventoryItemComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "InventoryItems",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "InventoryItems");
        }
    }
}
