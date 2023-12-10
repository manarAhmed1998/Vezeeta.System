using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AdminSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7d1c852-64c2-4b46-b430-113e0801bad6");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("40f63d61-4b92-4c46-81c8-1a9c191dab0c"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("75f2e9ca-c362-4a8f-9265-35cee3982015"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("8e3cb774-11ef-4560-9cb0-d9550941114b"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("999828b2-1ea4-41c6-9a1f-dc5953503732"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("b55737de-eca3-48db-a5f1-e4dcf5a80d01"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("b96986db-85bc-4928-a286-53954edff8b5"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("dc035a1b-b3dd-4d7c-9f53-eb7498dd0b83"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("e4dc585a-c7e7-41b4-9edb-ba1946cb9af1"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("fab108a2-5790-4fb3-8dd5-f5c7f393b660"));

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "bcb19302-1690-448c-987e-7c07592ce2b9");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "bcb19302-1690-448c-987e-7c07592ce2b9");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "bcb19302-1690-448c-987e-7c07592ce2b9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bcb19302-1690-448c-987e-7c07592ce2b9", 0, 2, "b14d974a-c86c-403e-a481-57b2b12c692b", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEFrGg4y9iZUJlrp4De8gonn/8ZDXr0nPPl06aAW3sr/UN6xOuaUB2AWegHYa9/DToQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("189c2b4b-0d29-4014-93fe-cb819204e177"), "طب الباطنة", "Internal Medicine" },
                    { new Guid("2781b78e-4c4e-4119-9edd-0fed9254f692"), "طب الاعصاب", "Neurology" },
                    { new Guid("5c1feb0a-7a39-4f3b-b38c-5d8a740543e5"), "طب اطفال", "Pediatrics" },
                    { new Guid("5c92fab2-7de0-483a-925e-6c1c51775df0"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("711e4651-9992-4881-9cf6-277441ba9455"), "المسالك البولية", "Urology" },
                    { new Guid("7e1b10bc-9841-4520-8d4c-a94e59aeb091"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("96c27dad-f525-4620-ac4a-e880f85b1a24"), "طب الاورام", "Oncology" },
                    { new Guid("b810d14d-9cff-4f78-861c-02bb68115c73"), "جلدية", "Dermatology" },
                    { new Guid("e9fd94c2-d0f5-4cc3-9ac2-35d6193df9b5"), "طب العيون", "Ophthalmology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcb19302-1690-448c-987e-7c07592ce2b9");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("189c2b4b-0d29-4014-93fe-cb819204e177"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("2781b78e-4c4e-4119-9edd-0fed9254f692"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("5c1feb0a-7a39-4f3b-b38c-5d8a740543e5"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("5c92fab2-7de0-483a-925e-6c1c51775df0"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("711e4651-9992-4881-9cf6-277441ba9455"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("7e1b10bc-9841-4520-8d4c-a94e59aeb091"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("96c27dad-f525-4620-ac4a-e880f85b1a24"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("b810d14d-9cff-4f78-861c-02bb68115c73"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("e9fd94c2-d0f5-4cc3-9ac2-35d6193df9b5"));

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: "d7d1c852-64c2-4b46-b430-113e0801bad6");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: "d7d1c852-64c2-4b46-b430-113e0801bad6");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: "d7d1c852-64c2-4b46-b430-113e0801bad6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AccountType", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d7d1c852-64c2-4b46-b430-113e0801bad6", 0, 2, "56f6f2d4-e156-4bb3-8bdf-a4572ba684af", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEE1F2GUlDVchZVjp0lKQoqdoxGc44Fu8npr9r4N/4X6woWsB8NOQmVbojfkibx4SzA==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("40f63d61-4b92-4c46-81c8-1a9c191dab0c"), "المسالك البولية", "Urology" },
                    { new Guid("75f2e9ca-c362-4a8f-9265-35cee3982015"), "طب الاورام", "Oncology" },
                    { new Guid("8e3cb774-11ef-4560-9cb0-d9550941114b"), "جلدية", "Dermatology" },
                    { new Guid("999828b2-1ea4-41c6-9a1f-dc5953503732"), "طب الباطنة", "Internal Medicine" },
                    { new Guid("b55737de-eca3-48db-a5f1-e4dcf5a80d01"), "طب العيون", "Ophthalmology" },
                    { new Guid("b96986db-85bc-4928-a286-53954edff8b5"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("dc035a1b-b3dd-4d7c-9f53-eb7498dd0b83"), "طب اطفال", "Pediatrics" },
                    { new Guid("e4dc585a-c7e7-41b4-9edb-ba1946cb9af1"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("fab108a2-5790-4fb3-8dd5-f5c7f393b660"), "طب الاعصاب", "Neurology" }
                });
        }
    }
}
