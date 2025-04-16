using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class updatingthingswithnewwebscrapercontent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6b47b7f4-ba62-4625-9993-9cdecbf57d2f"), 0, "2d6e3986-2a87-464f-a380-3611b3b28eb3", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), 0, "4026741b-3c58-4f7d-ab2d-52dc98d615b9", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("8c596cf9-9ee7-4770-b22c-a52569177a00"), 0, "3df3d42b-a9b1-4357-a044-a3d3fc75d3e3", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("acdd0657-7cf1-4121-bb21-0a49edda3312"), 0, "dc60aa8f-ed7f-477b-8d89-d68a2b410a6a", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("c6ebea0c-be35-400f-8eac-fd533773f5a7"), 0, "fa396aeb-e3a9-400a-ad34-faac74fe9abb", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("f4198380-d6b1-4d88-b397-b970e6ccee67"), 0, "66df36f2-c3a2-4dd9-937a-ef678ead0b3a", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "City", "Gender", "Hospital", "Name", "Specialty", "State", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("93a6a6ed-7e07-4943-9eba-4df0c069dba4"), null, null, null, null, "Dr. Taylor", "Cardiac Surgery", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null },
                    { new Guid("a2942e88-ae51-4f53-91e2-7cd42d2886df"), null, null, null, null, "Dr. Rogers", "Dermatology", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null },
                    { new Guid("b0ae4fcd-df25-44eb-98ac-11437d1e153a"), null, null, null, null, "Dr. Smith", "Allergy", null, new Guid("f4198380-d6b1-4d88-b397-b970e6ccee67"), null },
                    { new Guid("b7fc159e-b20e-478c-94b4-adfeab42ef3a"), null, null, null, null, "Dr. Banks", "Dermatology", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null },
                    { new Guid("d4ab11bf-223d-417c-9946-75a5e892cebe"), null, null, null, null, "Dr. White", "Chiropractic", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null },
                    { new Guid("df928327-1e93-49b9-b49c-5c5c3bfd36f7"), null, null, null, null, "Dr. Jordan", "Dermatology", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("236ec25e-f666-4663-a30f-b17216fb8386"), new Guid("6b47b7f4-ba62-4625-9993-9cdecbf57d2f") },
                    { new Guid("d026771e-63bc-4b7f-9d60-b75402f4a6a8"), new Guid("8c596cf9-9ee7-4770-b22c-a52569177a00") },
                    { new Guid("dad64934-beea-4c73-bb32-13fca27d6f24"), new Guid("acdd0657-7cf1-4121-bb21-0a49edda3312") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6ebea0c-be35-400f-8eac-fd533773f5a7"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("93a6a6ed-7e07-4943-9eba-4df0c069dba4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a2942e88-ae51-4f53-91e2-7cd42d2886df"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b0ae4fcd-df25-44eb-98ac-11437d1e153a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b7fc159e-b20e-478c-94b4-adfeab42ef3a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d4ab11bf-223d-417c-9946-75a5e892cebe"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("df928327-1e93-49b9-b49c-5c5c3bfd36f7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("236ec25e-f666-4663-a30f-b17216fb8386"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d026771e-63bc-4b7f-9d60-b75402f4a6a8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("dad64934-beea-4c73-bb32-13fca27d6f24"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b47b7f4-ba62-4625-9993-9cdecbf57d2f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8c596cf9-9ee7-4770-b22c-a52569177a00"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("acdd0657-7cf1-4121-bb21-0a49edda3312"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4198380-d6b1-4d88-b397-b970e6ccee67"));

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
    }
}
