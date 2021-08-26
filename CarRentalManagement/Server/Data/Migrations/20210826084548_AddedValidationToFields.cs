using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationToFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Models",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Makes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Colours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
