using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "TimeInHours",
                table: "Times",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0284db6c-f8e4-4c71-8bc2-56e7a202862f"), "طب العيون", "Ophthalmology" },
                    { new Guid("3b85c78d-f8c6-4b88-b3aa-c51326a69b37"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("474d06c8-92a4-47e0-b6e3-d6931bc52130"), "المسالك البولية", "Urology" },
                    { new Guid("4a379e62-73f1-4aee-987f-1ba641aaedcc"), "طب الاعصاب", "Neurology" },
                    { new Guid("64f0a7eb-ac8b-4d28-afbb-95079183968d"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("a7c71a90-4c89-43fc-a996-bdcefd54c9ca"), "طب اطفال", "Pediatrics" },
                    { new Guid("bb145f6c-8418-41a3-ac75-bfc1767f7c7a"), "طب الاورام", "Oncology" },
                    { new Guid("c0e389f3-a416-4b54-a90a-5d726f16622e"), "جلدية", "Dermatology" },
                    { new Guid("f1a92d10-13c6-48cb-8d0b-26ea110d316f"), "طب الباطنة", "Internal Medicine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("0284db6c-f8e4-4c71-8bc2-56e7a202862f"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("3b85c78d-f8c6-4b88-b3aa-c51326a69b37"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("474d06c8-92a4-47e0-b6e3-d6931bc52130"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("4a379e62-73f1-4aee-987f-1ba641aaedcc"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("64f0a7eb-ac8b-4d28-afbb-95079183968d"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("a7c71a90-4c89-43fc-a996-bdcefd54c9ca"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("bb145f6c-8418-41a3-ac75-bfc1767f7c7a"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("c0e389f3-a416-4b54-a90a-5d726f16622e"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("f1a92d10-13c6-48cb-8d0b-26ea110d316f"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeInHours",
                table: "Times",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
