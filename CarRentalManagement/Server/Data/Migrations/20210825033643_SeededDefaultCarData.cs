using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 25, 5, 36, 43, 346, DateTimeKind.Local).AddTicks(5417), new DateTime(2021, 8, 25, 5, 36, 43, 348, DateTimeKind.Local).AddTicks(7120), "Black", "System" },
                    { 2, "System", new DateTime(2021, 8, 25, 5, 36, 43, 348, DateTimeKind.Local).AddTicks(7674), new DateTime(2021, 8, 25, 5, 36, 43, 348, DateTimeKind.Local).AddTicks(7685), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 25, 5, 36, 43, 349, DateTimeKind.Local).AddTicks(6995), new DateTime(2021, 8, 25, 5, 36, 43, 349, DateTimeKind.Local).AddTicks(7010), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 8, 25, 5, 36, 43, 349, DateTimeKind.Local).AddTicks(7014), new DateTime(2021, 8, 25, 5, 36, 43, 349, DateTimeKind.Local).AddTicks(7016), "Volvo", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(38), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(49), "X5", "System" },
                    { 2, "System", new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(53), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(56), "X7", "System" },
                    { 3, "System", new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(58), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(60), "C40", "System" },
                    { 4, "System", new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(62), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(63), "XC90", "System" },
                    { 5, "System", new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(65), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(67), "V40", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}