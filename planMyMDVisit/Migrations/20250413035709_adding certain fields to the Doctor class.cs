using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class addingcertainfieldstotheDoctorclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f568747f-4353-41bb-9b18-15bc2118b657"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("030f3581-5099-4801-b99b-5ffc6a2d7f90"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("12de1005-7d7d-42f7-9fda-712d6ac28364"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("32194b1e-378e-4876-a43f-5dade88f415c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7869348e-8164-4632-b7cd-3aed5340e294"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("841ace29-6105-4150-a5aa-655bf05e64be"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e4f872c7-35df-469a-8fd1-207fc53800b9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2b6a3dda-ae8a-41e1-83b2-12db17774530"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4fc98e06-660f-4e1f-baf1-2bc11677a388"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d76d2c37-a7f4-4aed-a1e9-0c20b2fb0f78"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12fb7f01-a787-40c5-95f7-a098ec164c43"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1a00f44d-5217-4b59-b93e-fb654328f47b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f4ac63a-6f17-47c9-aa63-fa91ed9a5ae1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c2ad3930-79cb-4ccb-8874-d3d47f366aac"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4cc8d7a-6959-45a2-a26c-8ea081aec5ab"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hospital",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("10a24d88-8b1a-47ba-a558-309886283841"), 0, "e861839a-a605-4549-b599-16725c101419", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("10b74731-a11b-4923-8d02-08291efa8cb4"), 0, "cdf2e2a7-63e3-4cda-99f5-0ae08dd6569a", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("21b3645e-34f1-4257-9c39-ece2306468db"), 0, "579242e9-9755-4d4d-93ff-5038fceaaa2e", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("3899d5e0-f710-4e26-84f5-4929670f4cfb"), 0, "febb9e2a-7dea-423c-bc36-d0506844f363", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("5378af9a-b946-4082-be42-5d1adf8f64d4"), 0, "9a6f7211-e1de-4bbb-beb0-68500b04b4c5", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("77bd4b2b-f4e5-4387-b482-cba637487ec8"), 0, "972f3f39-438e-46d9-af83-30c27c783b60", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "City", "Gender", "Hospital", "Name", "Specialty", "State", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("113706d9-4c18-41ed-8770-a5cf48258be5"), null, null, null, null, "Dr. Banks", "Dermatology", null, new Guid("21b3645e-34f1-4257-9c39-ece2306468db"), null },
                    { new Guid("19b4da80-39f8-44c5-a544-893221d0c08a"), null, null, null, null, "Dr. Smith", "Allergy", null, new Guid("10a24d88-8b1a-47ba-a558-309886283841"), null },
                    { new Guid("285b8ba0-0f84-4e32-95e9-7fb824873a0c"), null, null, null, null, "Dr. Jordan", "Dermatology", null, new Guid("21b3645e-34f1-4257-9c39-ece2306468db"), null },
                    { new Guid("535c97b0-cd5f-43b5-b10f-23bd3c954c2d"), null, null, null, null, "Dr. Taylor", "Cardiac Surgery", null, new Guid("21b3645e-34f1-4257-9c39-ece2306468db"), null },
                    { new Guid("ad525324-5fb4-4c54-81ae-ebe2a100ee59"), null, null, null, null, "Dr. Rogers", "Dermatology", null, new Guid("21b3645e-34f1-4257-9c39-ece2306468db"), null },
                    { new Guid("c026a978-1be2-46db-acf2-ce122397905a"), null, null, null, null, "Dr. White", "Chiropractic", null, new Guid("21b3645e-34f1-4257-9c39-ece2306468db"), null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c6801d0-bd10-4d7b-ac6e-db0790961cc9"), new Guid("77bd4b2b-f4e5-4387-b482-cba637487ec8") },
                    { new Guid("4e6646db-be2b-444b-9c0e-0296eb259e07"), new Guid("3899d5e0-f710-4e26-84f5-4929670f4cfb") },
                    { new Guid("b192f28b-0421-400b-a7c2-39b57c47cd44"), new Guid("10b74731-a11b-4923-8d02-08291efa8cb4") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5378af9a-b946-4082-be42-5d1adf8f64d4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("113706d9-4c18-41ed-8770-a5cf48258be5"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("19b4da80-39f8-44c5-a544-893221d0c08a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("285b8ba0-0f84-4e32-95e9-7fb824873a0c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("535c97b0-cd5f-43b5-b10f-23bd3c954c2d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ad525324-5fb4-4c54-81ae-ebe2a100ee59"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c026a978-1be2-46db-acf2-ce122397905a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1c6801d0-bd10-4d7b-ac6e-db0790961cc9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4e6646db-be2b-444b-9c0e-0296eb259e07"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b192f28b-0421-400b-a7c2-39b57c47cd44"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("10a24d88-8b1a-47ba-a558-309886283841"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("10b74731-a11b-4923-8d02-08291efa8cb4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21b3645e-34f1-4257-9c39-ece2306468db"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3899d5e0-f710-4e26-84f5-4929670f4cfb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("77bd4b2b-f4e5-4387-b482-cba637487ec8"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Hospital",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "Doctors");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("12fb7f01-a787-40c5-95f7-a098ec164c43"), 0, "45e6313d-1f5a-48ba-ab1d-e39303ac7ab6", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("1a00f44d-5217-4b59-b93e-fb654328f47b"), 0, "e5561007-6755-444a-a9f6-9084bc80f4a9", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("8f4ac63a-6f17-47c9-aa63-fa91ed9a5ae1"), 0, "34d9a580-c5f9-48df-aa9f-1dc3e1241579", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("c2ad3930-79cb-4ccb-8874-d3d47f366aac"), 0, "80dd28fe-c8c7-4f85-a40e-2afe34b60e7e", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("d4cc8d7a-6959-45a2-a26c-8ea081aec5ab"), 0, "55245f49-7939-4fb8-a297-413abb017e6d", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("f568747f-4353-41bb-9b18-15bc2118b657"), 0, "d2956e37-33c3-4bbb-8600-bf7c841e73da", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("030f3581-5099-4801-b99b-5ffc6a2d7f90"), "Dr. Smith", "Allergy", new Guid("d4cc8d7a-6959-45a2-a26c-8ea081aec5ab") },
                    { new Guid("12de1005-7d7d-42f7-9fda-712d6ac28364"), "Dr. Jordan", "Dermatology", new Guid("8f4ac63a-6f17-47c9-aa63-fa91ed9a5ae1") },
                    { new Guid("32194b1e-378e-4876-a43f-5dade88f415c"), "Dr. Rogers", "Dermatology", new Guid("8f4ac63a-6f17-47c9-aa63-fa91ed9a5ae1") },
                    { new Guid("7869348e-8164-4632-b7cd-3aed5340e294"), "Dr. White", "Chiropractic", new Guid("8f4ac63a-6f17-47c9-aa63-fa91ed9a5ae1") },
                    { new Guid("841ace29-6105-4150-a5aa-655bf05e64be"), "Dr. Taylor", "Cardiac Surgery", new Guid("8f4ac63a-6f17-47c9-aa63-fa91ed9a5ae1") },
                    { new Guid("e4f872c7-35df-469a-8fd1-207fc53800b9"), "Dr. Banks", "Dermatology", new Guid("8f4ac63a-6f17-47c9-aa63-fa91ed9a5ae1") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("2b6a3dda-ae8a-41e1-83b2-12db17774530"), new Guid("12fb7f01-a787-40c5-95f7-a098ec164c43") },
                    { new Guid("4fc98e06-660f-4e1f-baf1-2bc11677a388"), new Guid("c2ad3930-79cb-4ccb-8874-d3d47f366aac") },
                    { new Guid("d76d2c37-a7f4-4aed-a1e9-0c20b2fb0f78"), new Guid("1a00f44d-5217-4b59-b93e-fb654328f47b") }
                });
        }
    }
}
