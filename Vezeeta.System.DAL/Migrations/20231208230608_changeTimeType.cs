using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class changeTimeType : Migration
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
                    { new Guid("26017fcd-8f95-4b68-b305-d11394713803"), "طب الاعصاب", "Neurology" },
                    { new Guid("27b04ccf-105e-4030-892a-2f8fdae6972b"), "المسالك البولية", "Urology" },
                    { new Guid("2bb37d32-95e0-40ae-a280-417c6ce86dce"), "طب الاورام", "Oncology" },
                    { new Guid("410ef534-8ce4-4d33-a350-8efc2dbce96f"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("47103274-8fb5-495d-880b-7130ea13ced0"), "طب العيون", "Ophthalmology" },
                    { new Guid("54de9711-e5c7-46ce-8099-09faac82c09f"), "طب الباطنة", "Internal Medicine" },
                    { new Guid("843bd4b9-10ff-4cb4-82db-1512010f1bed"), "جلدية", "Dermatology" },
                    { new Guid("bbb88d4e-5d8f-419f-9978-fab8a52522b6"), "طب اطفال", "Pediatrics" },
                    { new Guid("e54912c5-54f0-4dbf-afdc-b3c5d2ee58d7"), "القلب والاوعية الدموية", "Cardiology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("26017fcd-8f95-4b68-b305-d11394713803"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("27b04ccf-105e-4030-892a-2f8fdae6972b"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("2bb37d32-95e0-40ae-a280-417c6ce86dce"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("410ef534-8ce4-4d33-a350-8efc2dbce96f"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("47103274-8fb5-495d-880b-7130ea13ced0"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("54de9711-e5c7-46ce-8099-09faac82c09f"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("843bd4b9-10ff-4cb4-82db-1512010f1bed"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("bbb88d4e-5d8f-419f-9978-fab8a52522b6"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("e54912c5-54f0-4dbf-afdc-b3c5d2ee58d7"));

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
