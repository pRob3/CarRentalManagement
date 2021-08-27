using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71698054-b32d-4f19-be01-51f75ff92b62",
                column: "ConcurrencyStamp",
                value: "7b3b1afa-e0fa-4d04-a161-70cec6454f23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2",
                column: "ConcurrencyStamp",
                value: "f74609c5-9bfa-4ee6-982a-715d83253ace");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a247e3a-fea1-4df7-8410-tdef62de1052",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ce96b8a-44f5-4005-b1d5-e945b76f5347", "AQAAAAEAACcQAAAAEAb2Bw41uh4JM0rhOwhgw2fNqoQYI0ux1QL2mQC6iW9IYRz3ku1j5GDIB0Ud7y28XA==", "43a8354c-a6ae-4351-b613-139557bbb01d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd67e19c-be82-4195-be73-4f4f0de7a85c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3ca176d-3c2d-44a8-b13f-409f3c52a9af", "AQAAAAEAACcQAAAAEACwU1hP0geqflSxH3cj0J0+OUnk62U2eBIrBdxYmGW89ZcPyrMu64CBerIq+89Wpw==", "df6851ca-c831-444a-89d4-866ae08e5844" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 18, 1, 39, 180, DateTimeKind.Local).AddTicks(5887), new DateTime(2021, 8, 26, 18, 1, 39, 182, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 18, 1, 39, 182, DateTimeKind.Local).AddTicks(6800), new DateTime(2021, 8, 26, 18, 1, 39, 182, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(6063), new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(6079), new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9015), new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9030), new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9034), new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9038), new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9042), new DateTime(2021, 8, 26, 18, 1, 39, 183, DateTimeKind.Local).AddTicks(9043) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.AlterColumn<string>(
                name: "Vin",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71698054-b32d-4f19-be01-51f75ff92b62",
                column: "ConcurrencyStamp",
                value: "96c7df8f-e5c9-4a93-962e-862408139758");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2",
                column: "ConcurrencyStamp",
                value: "452a8730-db99-4c54-b618-611a13d1a49c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a247e3a-fea1-4df7-8410-tdef62de1052",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db18f74b-0c7b-4045-9647-518d8ed5f497", "AQAAAAEAACcQAAAAEDpAziLxY5/i4isVtyMzjRo46hLuYcIX7fjzL3X441HecXZgXLeYWesD4iUUtZu+Dg==", "7b157905-cede-4332-8bb1-8baeeac12b42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd67e19c-be82-4195-be73-4f4f0de7a85c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35d732d1-9e76-49a4-a092-c672f636d557", "AQAAAAEAACcQAAAAEC7N4/TS4MxWHWGWEhYwXni9OXVUzRe5XjwPg50yfotMRAOmDBHf/j8xIcbw+mZgbw==", "6b4f8426-7232-49a4-94f8-397b210d6dd4" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 45, 48, 341, DateTimeKind.Local).AddTicks(9653), new DateTime(2021, 8, 26, 10, 45, 48, 343, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 45, 48, 343, DateTimeKind.Local).AddTicks(9890), new DateTime(2021, 8, 26, 10, 45, 48, 343, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 45, 48, 344, DateTimeKind.Local).AddTicks(8832), new DateTime(2021, 8, 26, 10, 45, 48, 344, DateTimeKind.Local).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 45, 48, 344, DateTimeKind.Local).AddTicks(8849), new DateTime(2021, 8, 26, 10, 45, 48, 344, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1803), new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1819), new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1823), new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1827), new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1831), new DateTime(2021, 8, 26, 10, 45, 48, 345, DateTimeKind.Local).AddTicks(1833) });
        }
    }
}