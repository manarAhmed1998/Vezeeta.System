using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class removeImgClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0a8017ff-f288-4b99-b1e6-08c5d6dc278a"), "طب العيون", "Ophthalmology" },
                    { new Guid("0d9fd44a-1d8d-4f69-b460-2c4a9929aba4"), "طب الباطنة", "Internal Medicine" },
                    { new Guid("10bd1081-12a8-4c0c-a4d2-296e1e5f9695"), "جلدية", "Dermatology" },
                    { new Guid("4426f2d4-cc87-4037-9d8f-1346b5a6b2f4"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("486cbd41-96c0-433f-bf14-afdbb3abf103"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("58577e1a-e2aa-4f6c-bb40-f8f5d4aeb940"), "طب اطفال", "Pediatrics" },
                    { new Guid("97fefefb-23c1-4a71-b4fe-5b401e50a1cd"), "طب الاعصاب", "Neurology" },
                    { new Guid("b9d23fe1-6426-4a37-8f2e-df59a40030a1"), "طب الاورام", "Oncology" },
                    { new Guid("fe417eb4-8dd9-42b4-b65d-d6bd2bd07bfc"), "المسالك البولية", "Urology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("0a8017ff-f288-4b99-b1e6-08c5d6dc278a"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("0d9fd44a-1d8d-4f69-b460-2c4a9929aba4"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("10bd1081-12a8-4c0c-a4d2-296e1e5f9695"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("4426f2d4-cc87-4037-9d8f-1346b5a6b2f4"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("486cbd41-96c0-433f-bf14-afdbb3abf103"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("58577e1a-e2aa-4f6c-bb40-f8f5d4aeb940"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("97fefefb-23c1-4a71-b4fe-5b401e50a1cd"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("b9d23fe1-6426-4a37-8f2e-df59a40030a1"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("fe417eb4-8dd9-42b4-b65d-d6bd2bd07bfc"));

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
    }
}
