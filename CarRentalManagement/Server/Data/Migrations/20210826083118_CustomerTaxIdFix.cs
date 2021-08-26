using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class CustomerTaxIdFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71698054-b32d-4f19-be01-51f75ff92b62",
                column: "ConcurrencyStamp",
                value: "a869edc8-0da9-4f66-ab28-053c95f242f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2",
                column: "ConcurrencyStamp",
                value: "93715ade-8d5b-4dcd-92c6-aca5c5f70a0e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a247e3a-fea1-4df7-8410-tdef62de1052",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb836457-1c33-4456-a693-032410ba7cd6", "AQAAAAEAACcQAAAAEIUGjafq2q+Y+HhTBQJlXouehaCeqt7LrRFNpiy/3ysbGE84v7dawCXc34b9iLAx/g==", "59483975-eaf5-4db0-b44d-40a4cbf7566f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd67e19c-be82-4195-be73-4f4f0de7a85c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b818a506-9cb2-425d-9f97-dd4fe6f13d9e", "AQAAAAEAACcQAAAAEMoLvb3uxxBIYRZSAF7S3ZV2JHsqbhGJVUkKoudZdpadNyvyYV7sUlqzlsSYJAVgYw==", "b651b470-fecc-4034-af27-b4cd974e84ab" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 31, 17, 717, DateTimeKind.Local).AddTicks(1095), new DateTime(2021, 8, 26, 10, 31, 17, 719, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 31, 17, 719, DateTimeKind.Local).AddTicks(2682), new DateTime(2021, 8, 26, 10, 31, 17, 719, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(3295), new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(3311), new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6200), new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6215), new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6219), new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6221) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6223), new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6227), new DateTime(2021, 8, 26, 10, 31, 17, 720, DateTimeKind.Local).AddTicks(6229) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

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
    }
}
