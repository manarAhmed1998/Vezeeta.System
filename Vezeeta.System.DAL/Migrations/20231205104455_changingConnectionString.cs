using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class changingConnectionString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("3fd5ca4a-387a-4fb4-97a7-2480a00e95ae"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("4ecc86b7-0a34-4647-a79d-670454ff6748"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("7d7ec542-1147-474d-84ef-8d496c043418"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("8c9f4ed6-baeb-48de-b08b-4c96ce5fe195"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("9054cde9-4941-4bde-8fd1-924eda3616e3"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("b17b9759-5707-49d5-8433-f6c8d3d4c1e1"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("e13dd515-5c96-42cd-abec-a481e5a283f1"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("e41e6d22-a57a-4b3b-8b9b-600aad8ae223"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("ece78a87-bd56-4c92-829d-e19bff72fa46"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("3fd5ca4a-387a-4fb4-97a7-2480a00e95ae"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("4ecc86b7-0a34-4647-a79d-670454ff6748"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("7d7ec542-1147-474d-84ef-8d496c043418"), "طب الاورام", "Oncology" },
                    { new Guid("8c9f4ed6-baeb-48de-b08b-4c96ce5fe195"), "طب العيون", "Ophthalmology" },
                    { new Guid("9054cde9-4941-4bde-8fd1-924eda3616e3"), "المسالك البولية", "Urology" },
                    { new Guid("b17b9759-5707-49d5-8433-f6c8d3d4c1e1"), "طب الاعصاب", "Neurology" },
                    { new Guid("e13dd515-5c96-42cd-abec-a481e5a283f1"), "طب اطفال", "Pediatrics" },
                    { new Guid("e41e6d22-a57a-4b3b-8b9b-600aad8ae223"), "طب الباطنة", "Internal Medicine" },
                    { new Guid("ece78a87-bd56-4c92-829d-e19bff72fa46"), "جلدية", "Dermatology" }
                });
        }
    }
}
