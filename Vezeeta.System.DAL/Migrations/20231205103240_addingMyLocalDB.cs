using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addingMyLocalDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("1b08f437-7e1f-43a0-b556-4b1523c8131f"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("42759fea-a5e3-463b-addc-f81302afa111"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("50da526a-86d8-4497-915c-499e4996af10"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("669e2593-20bb-4ce3-88bd-61704a8ec179"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("8cd7f1c5-945f-42d5-8cb7-f241e36d3a8e"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("8e28bee7-0f15-457b-b479-18f085cdac57"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("97a95556-3789-44f6-8e83-e8df272136ba"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("c31ac45a-c9a5-42ee-9404-70b90fc6f3df"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("ef335ffd-8289-4238-a205-cfe48c2c1c77"));

            migrationBuilder.RenameColumn(
                name: "img",
                table: "Patients",
                newName: "Img");

            migrationBuilder.RenameColumn(
                name: "img",
                table: "Doctors",
                newName: "Img");

            migrationBuilder.AlterColumn<string>(
                name: "Img",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Patients",
                newName: "img");

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Doctors",
                newName: "img");

            migrationBuilder.AlterColumn<string>(
                name: "img",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("1b08f437-7e1f-43a0-b556-4b1523c8131f"), "طب العيون", "Ophthalmology" },
                    { new Guid("42759fea-a5e3-463b-addc-f81302afa111"), "طب الباطنة", "Internal Medicine" },
                    { new Guid("50da526a-86d8-4497-915c-499e4996af10"), "طب الاورام", "Oncology" },
                    { new Guid("669e2593-20bb-4ce3-88bd-61704a8ec179"), "طب اطفال", "Pediatrics" },
                    { new Guid("8cd7f1c5-945f-42d5-8cb7-f241e36d3a8e"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("8e28bee7-0f15-457b-b479-18f085cdac57"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("97a95556-3789-44f6-8e83-e8df272136ba"), "جلدية", "Dermatology" },
                    { new Guid("c31ac45a-c9a5-42ee-9404-70b90fc6f3df"), "المسالك البولية", "Urology" },
                    { new Guid("ef335ffd-8289-4238-a205-cfe48c2c1c77"), "طب الاعصاب", "Neurology" }
                });
        }
    }
}
