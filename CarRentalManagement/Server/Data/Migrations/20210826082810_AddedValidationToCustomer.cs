using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAdress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71698054-b32d-4f19-be01-51f75ff92b62",
                column: "ConcurrencyStamp",
                value: "346b3246-1a84-4805-9a71-27ad6a9f4f58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2",
                column: "ConcurrencyStamp",
                value: "b6a8e95f-5835-4587-8f72-a82375227dfe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a247e3a-fea1-4df7-8410-tdef62de1052",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "008f4873-0c88-4931-86c9-c7dbd9cc4e06", "AQAAAAEAACcQAAAAEA0Vj+hvj/Mx93vKQ/x9EqYyQaVy3oli1agoVRnHB/b1X5Bcr66esc4UAQD7L98v2w==", "ff4215d6-0e3b-4f3f-b1ac-ac89fd6a6110" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd67e19c-be82-4195-be73-4f4f0de7a85c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c15c9e2c-4add-4b21-a67d-a4abe9dea524", "AQAAAAEAACcQAAAAENcXYBlDF/0Bli1ZnIowBOCJIfTKau8qQr/zWhaQbv84bNUpAWda5zzx41COPaXZdw==", "37aa5ac1-356f-4982-9ec2-1bfdeadbe9d2" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 28, 10, 286, DateTimeKind.Local).AddTicks(5575), new DateTime(2021, 8, 26, 10, 28, 10, 288, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 28, 10, 288, DateTimeKind.Local).AddTicks(6395), new DateTime(2021, 8, 26, 10, 28, 10, 288, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(5465), new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(5480), new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8460), new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8475), new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8480), new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8482) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8484), new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8487), new DateTime(2021, 8, 26, 10, 28, 10, 289, DateTimeKind.Local).AddTicks(8489) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAdress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}