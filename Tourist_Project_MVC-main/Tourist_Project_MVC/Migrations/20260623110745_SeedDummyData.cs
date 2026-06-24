using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tourist_Project_MVC.Migrations
{
    /// <inheritdoc />
    public partial class SeedDummyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "Id", "City", "Lat", "Long", "Name", "description" },
                values: new object[,]
                {
                    { 1, "Paris", 48.8584f, 2.2945f, "Eiffel Tower", "Iconic iron tower." },
                    { 2, "Rome", 41.8902f, 12.4922f, "Colosseum", "Ancient Roman amphitheater." }
                });

            migrationBuilder.InsertData(
                table: "Sponsors",
                columns: new[] { "Id", "Address", "ContactNumber", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "123 Main St, London", 5550192, "Global Travel Co.", "Agency" },
                    { 2, "456 Green Rd, Berlin", 5550143, "EcoStay Hotels", "Hospitality" }
                });

            migrationBuilder.InsertData(
                table: "Tourists",
                columns: new[] { "Id", "Email", "IdNumber", "Name", "Nationality", "Passport", "Password", "RegisterDate", "point_Balance" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "US123456", "John Doe", "American", "P987654", "HashedPassword123", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 150 },
                    { 2, "jane.smith@example.com", "UK789101", "Jane Smith", "British", "P112233", "HashedPassword456", new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 }
                });

            migrationBuilder.InsertData(
                table: "Missions",
                columns: new[] { "Id", "Description", "DestinationId", "PointsReward", "Title" },
                values: new object[,]
                {
                    { 1, "Take a photo at the top of the Eiffel Tower", 1, 100, "Parisian Explorer" },
                    { 2, "Visit the underground chambers of the Colosseum", 2, 120, "Gladiator Walk" }
                });

            migrationBuilder.InsertData(
                table: "Rewards",
                columns: new[] { "Id", "Description", "ExpirationDate", "PointsRequired", "QuantityAvailable", "SponsorId", "Title" },
                values: new object[,]
                {
                    { 1, "Get 10% off your next stay at EcoStay", new DateTime(2027, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 50, 2, "10% Hotel Discount" },
                    { 2, "Complimentary walking tour by Global Travel Co.", new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 20, 1, "Free City Tour" }
                });

            migrationBuilder.InsertData(
                table: "TripPlans",
                columns: new[] { "Id", "EndDate", "StartDate", "Title", "TouristId" },
                values: new object[] { 1, new DateTime(2026, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Summer Europe Trip", 1 });

            migrationBuilder.InsertData(
                table: "Redemptions",
                columns: new[] { "Id", "Code", "PointsRedeemed", "RedemptionDate", "RewardId", "Status", "TouristId" },
                values: new object[] { 1, "ECO10-XYZ", 100, new DateTime(2026, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Active", 1 });

            migrationBuilder.InsertData(
                table: "TripDestinations",
                columns: new[] { "Id", "ArrivalDate", "DepartureDate", "DestinationId", "TripPlanId", "Visit_Order" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1 },
                    { 2, new DateTime(2026, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "UserMissions",
                columns: new[] { "Id", "Completed_At", "MissionId", "PointsEarned", "Status", "TouristId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 100, "Completed", 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "In Progress", 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Redemptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rewards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TripDestinations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TripDestinations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserMissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserMissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Missions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rewards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TripPlans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Destinations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sponsors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tourists",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
