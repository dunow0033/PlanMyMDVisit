using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class addingusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9a10a293-ccf7-4b5d-9a09-4677f35aaa2b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a3beb5-f9d8-482e-900e-5ee6362d2567"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("09779ae8-a4c6-4eba-ae83-56560c34e83f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("12495cdc-1376-4cbf-9ee7-4f285bd235c4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1a6fbde2-ba49-4703-8069-da574a645e8b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("593ee63f-c4f6-4994-a77c-80d1336761ac"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("70150ae9-efef-419d-8d2c-4d9ca7531f9d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e9b8a66e-87c6-4da3-8708-1450ff4287d6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3d3b81d2-3219-4d9e-9efe-50aa11ea520b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("875681e9-d401-4ea6-a033-3704dd3a7d5d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("3d3b81d2-3219-4d9e-9efe-50aa11ea520b"), 0, "b45e3ee6-97cd-43cd-aafc-6bda03a73a85", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("875681e9-d401-4ea6-a033-3704dd3a7d5d"), 0, "a89eee02-bf7f-44ef-bc00-fe648d691a81", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("9a10a293-ccf7-4b5d-9a09-4677f35aaa2b"), 0, "d6373ef7-9516-440a-8759-4dd6905f0fef", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("c3a3beb5-f9d8-482e-900e-5ee6362d2567"), 0, "c5914357-190c-42ae-ae25-817e39bf2dc7", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("09779ae8-a4c6-4eba-ae83-56560c34e83f"), "Dr. Taylor", "Cardiac Surgery", new Guid("875681e9-d401-4ea6-a033-3704dd3a7d5d") },
                    { new Guid("12495cdc-1376-4cbf-9ee7-4f285bd235c4"), "Dr. Rogers", "Dermatology", new Guid("875681e9-d401-4ea6-a033-3704dd3a7d5d") },
                    { new Guid("1a6fbde2-ba49-4703-8069-da574a645e8b"), "Dr. Smith", "Allergy", new Guid("3d3b81d2-3219-4d9e-9efe-50aa11ea520b") },
                    { new Guid("593ee63f-c4f6-4994-a77c-80d1336761ac"), "Dr. Jordan", "Dermatology", new Guid("875681e9-d401-4ea6-a033-3704dd3a7d5d") },
                    { new Guid("70150ae9-efef-419d-8d2c-4d9ca7531f9d"), "Dr. White", "Chiropractic", new Guid("875681e9-d401-4ea6-a033-3704dd3a7d5d") },
                    { new Guid("e9b8a66e-87c6-4da3-8708-1450ff4287d6"), "Dr. Banks", "Dermatology", new Guid("875681e9-d401-4ea6-a033-3704dd3a7d5d") }
                });
        }
    }
}
