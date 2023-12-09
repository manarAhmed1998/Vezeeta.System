using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class uniqueDIdDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments");

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId_Day",
                table: "Appointments",
                columns: new[] { "DoctorId", "Day" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorId_Day",
                table: "Appointments");

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");
        }
    }
}
