using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class MadeDateInNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71698054-b32d-4f19-be01-51f75ff92b62",
                column: "ConcurrencyStamp",
                value: "50efbb94-0284-4ea9-8756-051b2487fca8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2",
                column: "ConcurrencyStamp",
                value: "052ed4be-d89b-436a-afaf-cab85a8e2124");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a247e3a-fea1-4df7-8410-tdef62de1052",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91dd11a3-d20a-4731-9b93-e65c588ff6cc", "AQAAAAEAACcQAAAAELRJWzpagZlx2NNkAyVjImfhq+9+T8HpbOqSP26K0IobnEzsWhwk0WjDCBgE4Mj+3g==", "ac330344-5b96-4a86-b969-d7e3807ffbc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd67e19c-be82-4195-be73-4f4f0de7a85c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fb3fcb4-81b6-4823-bfe7-336651166b28", "AQAAAAEAACcQAAAAEH3tC+D20EV9NID8gs0HU6Sl5lsrAdBLy/QEOnQ+lzyiFHdcDjlN8dEi4T9TgsC7Og==", "2aecc5aa-98f6-4786-a120-c0a45a033f15" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 0, 0, 340, DateTimeKind.Local).AddTicks(1424), new DateTime(2021, 8, 25, 6, 0, 0, 342, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 0, 0, 342, DateTimeKind.Local).AddTicks(3468), new DateTime(2021, 8, 25, 6, 0, 0, 342, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(5886), new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(5933), new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9169), new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9184), new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9188), new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9192), new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9196), new DateTime(2021, 8, 25, 6, 0, 0, 343, DateTimeKind.Local).AddTicks(9198) });
        }
    }
}
