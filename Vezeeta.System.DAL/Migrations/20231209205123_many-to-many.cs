using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Vezeeta.System.DAL.Migrations
{
    /// <inheritdoc />
    public partial class manytomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Gender",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatientCoupons",
                columns: table => new
                {
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CouponId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientCoupons", x => new { x.PatientId, x.CouponId });
                    table.ForeignKey(
                        name: "FK_PatientCoupons_Coupons_CouponId",
                        column: x => x.CouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientCoupons_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { new Guid("13e6f624-0686-4d62-ae97-47ce6b47aeb9"), "القلب والاوعية الدموية", "Cardiology" },
                    { new Guid("48afccee-c5d9-41c7-9df7-08f4232c8076"), "جلدية", "Dermatology" },
                    { new Guid("70c8b159-62b5-42bd-bffc-85e01fbcf83c"), "طب الاورام", "Oncology" },
                    { new Guid("79f082f9-1aac-4b0e-8935-dafd76c01aa9"), "طب الاعصاب", "Neurology" },
                    { new Guid("a829b4b5-cdc4-4428-8f7f-34900704e462"), "طب العيون", "Ophthalmology" },
                    { new Guid("c83627ea-5316-4c04-94e6-2fdc5ee6ae10"), "طب الباطنة", "Internal Medicine" },
                    { new Guid("d0f20b02-5419-4f90-9080-6b00a75b0e9b"), "المسالك البولية", "Urology" },
                    { new Guid("daf5b1b4-208c-4f91-8932-10157b48ea6c"), "نساء وتوليد", "Obstetrics and Gynecology" },
                    { new Guid("e6c2bc81-6bbc-4cb2-be5a-afd99c9a9962"), "طب اطفال", "Pediatrics" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PatientCoupons_CouponId",
                table: "PatientCoupons",
                column: "CouponId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientCoupons");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("13e6f624-0686-4d62-ae97-47ce6b47aeb9"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("48afccee-c5d9-41c7-9df7-08f4232c8076"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("70c8b159-62b5-42bd-bffc-85e01fbcf83c"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("79f082f9-1aac-4b0e-8935-dafd76c01aa9"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("a829b4b5-cdc4-4428-8f7f-34900704e462"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("c83627ea-5316-4c04-94e6-2fdc5ee6ae10"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("d0f20b02-5419-4f90-9080-6b00a75b0e9b"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("daf5b1b4-208c-4f91-8932-10157b48ea6c"));

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Id",
                keyValue: new Guid("e6c2bc81-6bbc-4cb2-be5a-afd99c9a9962"));

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Gender",
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
    }
}
