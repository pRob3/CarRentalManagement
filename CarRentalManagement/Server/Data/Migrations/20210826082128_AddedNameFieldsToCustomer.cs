using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedNameFieldsToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71698054-b32d-4f19-be01-51f75ff92b62",
                column: "ConcurrencyStamp",
                value: "afdeec5c-68d5-4aea-980b-8b11dd4ca809");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2",
                column: "ConcurrencyStamp",
                value: "747a2661-e3a4-40da-8765-ab038c7adca4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a247e3a-fea1-4df7-8410-tdef62de1052",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef021dc5-252a-47e6-be2a-b8f9a49f0c4b", "AQAAAAEAACcQAAAAEMdYPqKMu7+9d4lA83Pdj8E41bkyOPfxK0DOg/PPopauAo/FpMed/RoSDAOuDbI+8w==", "4f32a3e8-219c-4ccd-a1c8-644f8279daa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd67e19c-be82-4195-be73-4f4f0de7a85c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2d2003f-eef7-4f37-9d28-32f25843c9e8", "AQAAAAEAACcQAAAAEFQ6o6KmeGyYeHZGs9MOfaWXlKzDzjmjvTTOciKDqhW/Yf85PxEnZe0mucirChiOZw==", "c3e178bb-2b90-41c8-acb5-61f394acc686" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 21, 27, 748, DateTimeKind.Local).AddTicks(5037), new DateTime(2021, 8, 26, 10, 21, 27, 750, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 21, 27, 750, DateTimeKind.Local).AddTicks(5622), new DateTime(2021, 8, 26, 10, 21, 27, 750, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(4500), new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(4516), new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7635), new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7650), new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7655), new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7658), new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7662), new DateTime(2021, 8, 26, 10, 21, 27, 751, DateTimeKind.Local).AddTicks(7664) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71698054-b32d-4f19-be01-51f75ff92b62",
                column: "ConcurrencyStamp",
                value: "2b4c9cfd-3902-47e7-97c3-ca42f66c201f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2",
                column: "ConcurrencyStamp",
                value: "4b66c1dd-804b-4995-a410-067049ab4d7b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a247e3a-fea1-4df7-8410-tdef62de1052",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3c16058-3d21-43b9-8ddc-d513b1ae9b69", "AQAAAAEAACcQAAAAEOhVl6RQYUhR+SwSIIGVOVvp86fOnbmpo/l9mqTdJsdgDACcmqECpBAZ8mhoNOR5Vg==", "75000064-4a62-442b-8018-bd13f8d33829" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd67e19c-be82-4195-be73-4f4f0de7a85c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eedb47e1-3904-4233-a44b-9846bff4942a", "AQAAAAEAACcQAAAAEL9GGefwYjKNpL6B0L3fA1C8DFnMQzd7DT352NdXCPrbzg3ni02bkM8gbPo+2VQrjQ==", "6db11e2b-b829-47b5-8415-7a414717dcf1" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 45, 50, 73, DateTimeKind.Local).AddTicks(2252), new DateTime(2021, 8, 26, 9, 45, 50, 75, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 45, 50, 75, DateTimeKind.Local).AddTicks(2801), new DateTime(2021, 8, 26, 9, 45, 50, 75, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(1784), new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(1800), new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4833), new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4847), new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4851), new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4855), new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4859), new DateTime(2021, 8, 26, 9, 45, 50, 76, DateTimeKind.Local).AddTicks(4861) });
        }
    }
}
