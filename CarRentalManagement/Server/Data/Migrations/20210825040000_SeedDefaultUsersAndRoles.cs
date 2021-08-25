using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "dd67e19c-be82-4195-be73-4f4f0de7a85c", 0, "0fb3fcb4-81b6-4823-bfe7-336651166b28", "admin@example.com", false, "System", "Admin", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEH3tC+D20EV9NID8gs0HU6Sl5lsrAdBLy/QEOnQ+lzyiFHdcDjlN8dEi4T9TgsC7Og==", null, false, "2aecc5aa-98f6-4786-a120-c0a45a033f15", false, "admin@example.com" },
                    { "3a247e3a-fea1-4df7-8410-tdef62de1052", 0, "91dd11a3-d20a-4731-9b93-e65c588ff6cc", "user@example.com", false, "System", "User", false, null, "USER@EXAMPLE.COM", "USER@EXAMPLE.COM", "AQAAAAEAACcQAAAAELRJWzpagZlx2NNkAyVjImfhq+9+T8HpbOqSP26K0IobnEzsWhwk0WjDCBgE4Mj+3g==", null, false, "ac330344-5b96-4a86-b969-d7e3807ffbc1", false, "user@example.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "71698054-b32d-4f19-be01-51f75ff92b62", "dd67e19c-be82-4195-be73-4f4f0de7a85c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2", "3a247e3a-fea1-4df7-8410-tdef62de1052" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2", "3a247e3a-fea1-4df7-8410-tdef62de1052" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71698054-b32d-4f19-be01-51f75ff92b62", "dd67e19c-be82-4195-be73-4f4f0de7a85c" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a247e3a-fea1-4df7-8410-tdef62de1052");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd67e19c-be82-4195-be73-4f4f0de7a85c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71698054-b32d-4f19-be01-51f75ff92b62",
                column: "ConcurrencyStamp",
                value: "c76b80d4-6963-4a14-b862-de77a5df4fc9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5cbf7bc-87fc-4c4d-af3c-cd132acd1dd2",
                column: "ConcurrencyStamp",
                value: "3f9cf154-3f26-4393-aad1-6fdac33e10d8");

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
    }
}
