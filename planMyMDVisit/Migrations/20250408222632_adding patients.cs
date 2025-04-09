using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class addingpatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7ccba912-e87c-40a4-b5d4-813f08bb5d52"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88e46d6e-c59e-416c-8a04-e80e1069f91a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cc96631f-172a-47f2-8fa0-968e3ce59756"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f7d8cd3d-2e10-404b-a535-13927c751145"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("205a32dc-15c3-40c3-baa1-97c5ce784646"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("68233d0a-610a-4d39-9387-6ec997294506"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6fd830f8-87ec-4158-b349-7af161983bc0"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("87fb2ade-1c8f-469a-aa4b-49bcaa712153"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a7d7fce8-337c-42c9-877b-2339f361b801"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ca43263b-1d1e-4b9a-b320-2091a954a8b6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9fae4ce8-d00a-413f-a134-da134ae6cbef"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3868c4d-938c-4a41-9a0d-44e91cffbc3d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("7ccba912-e87c-40a4-b5d4-813f08bb5d52"), 0, "0d1e651f-0cf2-475b-b456-f9621992fe89", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("88e46d6e-c59e-416c-8a04-e80e1069f91a"), 0, "bf4f6d4f-3148-4352-8976-92814715f57d", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("9fae4ce8-d00a-413f-a134-da134ae6cbef"), 0, "920a3a2f-d698-4968-85e1-2921d630886a", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("cc96631f-172a-47f2-8fa0-968e3ce59756"), 0, "a0e326d3-4cc4-4a26-a468-ba841e0d9e96", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("f3868c4d-938c-4a41-9a0d-44e91cffbc3d"), 0, "0a7c7d1f-b253-40ab-a459-5616dd95174b", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("f7d8cd3d-2e10-404b-a535-13927c751145"), 0, "56f6ebbd-cff7-487c-a05f-4f9fedb2b88b", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("205a32dc-15c3-40c3-baa1-97c5ce784646"), "Dr. Banks", "Dermatology", new Guid("f3868c4d-938c-4a41-9a0d-44e91cffbc3d") },
                    { new Guid("68233d0a-610a-4d39-9387-6ec997294506"), "Dr. Smith", "Allergy", new Guid("9fae4ce8-d00a-413f-a134-da134ae6cbef") },
                    { new Guid("6fd830f8-87ec-4158-b349-7af161983bc0"), "Dr. Jordan", "Dermatology", new Guid("f3868c4d-938c-4a41-9a0d-44e91cffbc3d") },
                    { new Guid("87fb2ade-1c8f-469a-aa4b-49bcaa712153"), "Dr. Rogers", "Dermatology", new Guid("f3868c4d-938c-4a41-9a0d-44e91cffbc3d") },
                    { new Guid("a7d7fce8-337c-42c9-877b-2339f361b801"), "Dr. White", "Chiropractic", new Guid("f3868c4d-938c-4a41-9a0d-44e91cffbc3d") },
                    { new Guid("ca43263b-1d1e-4b9a-b320-2091a954a8b6"), "Dr. Taylor", "Cardiac Surgery", new Guid("f3868c4d-938c-4a41-9a0d-44e91cffbc3d") }
                });
        }
    }
}
