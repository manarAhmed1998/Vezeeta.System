using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EditDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("2e57af04-6a21-4865-b030-380f4c663e70"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("44be8d9c-a382-4374-bdc7-7a278f019d93"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("536ce280-68ae-45f3-a964-937929f389f0"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("778225cc-bfa2-4020-a0ab-c84cb52bab4c"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("b24abadf-cc51-4961-ab85-61e68360ef65"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("b9b9ac65-4fdb-44e9-b3e4-93d5501aae31"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("c1ec08fd-f1ea-4512-b661-a983121a9675"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("de51da26-a064-42bf-bb64-ff2e65d3b0a1"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("e5cc0798-93cd-4799-a786-65b3838157ae"));

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Doctors");

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("0e75a5f0-6991-4084-96f1-b1f1a9dfaa11"), "طب العيون", "Ophthalmology" },
                    { new Guid("16fbb828-611b-47d9-b2d5-f927fd86cd13"), "طب اطفال", "Pediatrics" },
                    { new Guid("17a4a4f3-5e40-4729-a836-a3b19abbe2b5"), "طب الاعصاب", "Neurology" },
                    { new Guid("2c00c4bf-a319-4b80-816d-c6104885df7a"), "طب الاورام", "Oncology" },
                    { new Guid("2cef488f-2824-4016-b4b2-d8c7065d2f7b"), "طب الباطنة", "Internal Medicine" },
                    { new Guid("32757065-c074-4bbe-8ec2-81bfe19ef19a"), "جلدية", "Dermatology" },
                    { new Guid("4892acfe-08c5-43e6-9ee0-7e56b6da7158"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("5c53542d-3205-4f99-822d-fde2e2879058"), "المسالك البولية", "Urology" },
                    { new Guid("a8a4ca02-55cb-493a-a74c-5aa2a1ce7009"), "القلب والاوعية الدموية", "Cardiology" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("0e75a5f0-6991-4084-96f1-b1f1a9dfaa11"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("16fbb828-611b-47d9-b2d5-f927fd86cd13"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("17a4a4f3-5e40-4729-a836-a3b19abbe2b5"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("2c00c4bf-a319-4b80-816d-c6104885df7a"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("2cef488f-2824-4016-b4b2-d8c7065d2f7b"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("32757065-c074-4bbe-8ec2-81bfe19ef19a"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("4892acfe-08c5-43e6-9ee0-7e56b6da7158"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("5c53542d-3205-4f99-822d-fde2e2879058"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("a8a4ca02-55cb-493a-a74c-5aa2a1ce7009"));

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("2e57af04-6a21-4865-b030-380f4c663e70"), "طب الاورام", "Oncology" },
                    { new Guid("44be8d9c-a382-4374-bdc7-7a278f019d93"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("536ce280-68ae-45f3-a964-937929f389f0"), "طب الاعصاب", "Neurology" },
                    { new Guid("778225cc-bfa2-4020-a0ab-c84cb52bab4c"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("b24abadf-cc51-4961-ab85-61e68360ef65"), "طب الباطنة", "Internal Medicine" },
                    { new Guid("b9b9ac65-4fdb-44e9-b3e4-93d5501aae31"), "طب العيون", "Ophthalmology" },
                    { new Guid("c1ec08fd-f1ea-4512-b661-a983121a9675"), "المسالك البولية", "Urology" },
                    { new Guid("de51da26-a064-42bf-bb64-ff2e65d3b0a1"), "طب اطفال", "Pediatrics" },
                    { new Guid("e5cc0798-93cd-4799-a786-65b3838157ae"), "جلدية", "Dermatology" }
                });
        }
    }
}
