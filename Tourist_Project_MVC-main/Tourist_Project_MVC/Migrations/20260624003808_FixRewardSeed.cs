using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tourist_Project_MVC.Migrations
{
    /// <inheritdoc />
    public partial class FixRewardSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RewardType",
                table: "Rewards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MissionType",
                table: "Missions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OpeningHours",
                table: "Destinations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TicketPrice",
                table: "Destinations",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "OpeningHours", "TicketPrice" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "OpeningHours", "TicketPrice" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 1,
                column: "MissionType",
                value: "Photography");

            migrationBuilder.UpdateData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 2,
                column: "MissionType",
                value: "Exploration");

            migrationBuilder.UpdateData(
                table: "Rewards",
                keyColumn: "Id",
                keyValue: 1,
                column: "RewardType",
                value: "Discount");

            migrationBuilder.UpdateData(
                table: "Rewards",
                keyColumn: "Id",
                keyValue: 2,
                column: "RewardType",
                value: "Experience");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RewardType",
                table: "Rewards");

            migrationBuilder.DropColumn(
                name: "MissionType",
                table: "Missions");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "OpeningHours",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "TicketPrice",
                table: "Destinations");
        }
    }
}
