using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2", "3f9cf154-3f26-4393-aad1-6fdac33e10d8", "User", "USER" },
                    { "71698054-b32d-4f19-be01-51f75ff92b62", "c76b80d4-6963-4a14-b862-de77a5df4fc9", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 43, 34, 872, DateTimeKind.Local).AddTicks(3242), new DateTime(2021, 8, 25, 5, 43, 34, 874, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 43, 34, 874, DateTimeKind.Local).AddTicks(5867), new DateTime(2021, 8, 25, 5, 43, 34, 874, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 43, 34, 875, DateTimeKind.Local).AddTicks(7917), new DateTime(2021, 8, 25, 5, 43, 34, 875, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 43, 34, 875, DateTimeKind.Local).AddTicks(7968), new DateTime(2021, 8, 25, 5, 43, 34, 875, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1387), new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1412), new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1416), new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1420), new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1424), new DateTime(2021, 8, 25, 5, 43, 34, 876, DateTimeKind.Local).AddTicks(1425) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71698054-b32d-4f19-be01-51f75ff92b62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 36, 43, 346, DateTimeKind.Local).AddTicks(5417), new DateTime(2021, 8, 25, 5, 36, 43, 348, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 36, 43, 348, DateTimeKind.Local).AddTicks(7674), new DateTime(2021, 8, 25, 5, 36, 43, 348, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 36, 43, 349, DateTimeKind.Local).AddTicks(6995), new DateTime(2021, 8, 25, 5, 36, 43, 349, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 36, 43, 349, DateTimeKind.Local).AddTicks(7014), new DateTime(2021, 8, 25, 5, 36, 43, 349, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(38), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(53), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(58), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(62), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(65), new DateTime(2021, 8, 25, 5, 36, 43, 350, DateTimeKind.Local).AddTicks(67) });
        }
    }
}
