using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dbTrial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("08e5edc0-8633-46a9-9808-0eda2e94f0af"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("16e38c2b-67b5-4e2a-9e28-1f89491e8d2a"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("636cbf8a-129f-451a-85a7-b2c060870582"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("78d56622-30f6-4b48-8ba4-ec5bd63b19a8"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("8bdb03c2-5c0f-4d3d-8406-7a025e2d0cd5"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("a7f46a05-4692-4ae4-b62d-36035804c1e2"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("b280bf89-7696-40f5-aa88-3517485555d4"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("ba8a0c90-ffd7-4d74-8b70-4225f19f2706"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("eedad649-148d-4dbc-8461-1611953c6bbe"));

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("060e23eb-6a81-4dbf-a8e3-0902c0f4b500"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("092bff87-fcd2-4680-9df4-b183842da4d9"), "طب اطفال", "Pediatrics" },
                    { new Guid("110dc8e8-ae9b-40eb-ac57-2445abe20c79"), "طب الاورام", "Oncology" },
                    { new Guid("534cb8fe-b185-4692-b0a8-94eee8f307f0"), "المسالك البولية", "Urology" },
                    { new Guid("5794fa5b-d4ec-4a1d-9a49-2610a0a8bdd3"), "طب العيون", "Ophthalmology" },
                    { new Guid("6b5eb3a4-7d02-4872-a8d7-97bfe6a7a33e"), "جلدية", "Dermatology" },
                    { new Guid("974554ad-07bc-4ba8-b955-89b0b905cd2b"), "طب الاعصاب", "Neurology" },
                    { new Guid("b31505d5-33a5-4dbf-b505-18bd422def19"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("ed1eed6a-7707-472d-9289-c1ca9244f7d8"), "طب الباطنة", "Internal Medicine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("060e23eb-6a81-4dbf-a8e3-0902c0f4b500"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("092bff87-fcd2-4680-9df4-b183842da4d9"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("110dc8e8-ae9b-40eb-ac57-2445abe20c79"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("534cb8fe-b185-4692-b0a8-94eee8f307f0"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("5794fa5b-d4ec-4a1d-9a49-2610a0a8bdd3"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("6b5eb3a4-7d02-4872-a8d7-97bfe6a7a33e"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("974554ad-07bc-4ba8-b955-89b0b905cd2b"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("b31505d5-33a5-4dbf-b505-18bd422def19"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("ed1eed6a-7707-472d-9289-c1ca9244f7d8"));

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("08e5edc0-8633-46a9-9808-0eda2e94f0af"), "طب العيون", "Ophthalmology" },
                    { new Guid("16e38c2b-67b5-4e2a-9e28-1f89491e8d2a"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("636cbf8a-129f-451a-85a7-b2c060870582"), "طب الاعصاب", "Neurology" },
                    { new Guid("78d56622-30f6-4b48-8ba4-ec5bd63b19a8"), "جلدية", "Dermatology" },
                    { new Guid("8bdb03c2-5c0f-4d3d-8406-7a025e2d0cd5"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("a7f46a05-4692-4ae4-b62d-36035804c1e2"), "المسالك البولية", "Urology" },
                    { new Guid("b280bf89-7696-40f5-aa88-3517485555d4"), "طب الاورام", "Oncology" },
                    { new Guid("ba8a0c90-ffd7-4d74-8b70-4225f19f2706"), "طب اطفال", "Pediatrics" },
                    { new Guid("eedad649-148d-4dbc-8461-1611953c6bbe"), "طب الباطنة", "Internal Medicine" }
                });
        }
    }
}
