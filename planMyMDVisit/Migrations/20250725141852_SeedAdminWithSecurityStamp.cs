using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminWithSecurityStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("039ae53c-e632-49c8-b086-17cd2eef5962"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2fe9bd40-5801-4f53-bff2-499c1ed85438"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("627e9014-aeda-4b79-a67b-e15f8a714f00"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8d03cde7-7a38-47ea-ad7f-0b27f2eed675"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("da451dad-ac46-4d74-9bae-69ad16057ec7"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("dc76db08-15d4-4a9f-84cf-08a768bc4b1a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("738e2436-4b3b-4086-96d2-54026b6632b8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("8eb7cab2-4022-4f24-8a67-9fad20ccfbe3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("920dff7e-8750-4bb9-9261-03c4b2143069"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("934de294-2b12-42b1-b9b9-8393e214e56c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e5d9a825-7536-4fe4-8977-7d6ddb820b66"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f20645ae-f49e-4c27-bbc6-b900a54d01e8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("013624b8-db0f-4914-bb45-056dcc2fc9a4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("05718fd3-8a37-4d41-ae7d-1558cc1bb257"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e2ede5c-d8d3-423b-83e8-b13da520df9c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("231bc597-716d-4d2a-b9e3-10c0cf6e3dd3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d306ff7-1198-476d-abf4-4e584ca3f18e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("526b6e2b-3c82-4c8d-9599-58c329dabc08"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5c82102b-ac17-4ec6-95e3-e8bfa2dc35c0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f73ac20-a572-4fcb-a486-d29b49a77e85"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("adaab996-9cb1-420b-966e-08043cfbbf9f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aecab71f-79a7-4265-b13f-ff76e833b370"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b81eb3c1-bed1-4d41-90c1-1b3428dc7492"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e79b0f36-a642-44c0-afae-661336d7fcaf"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9793e6ce-d724-411e-b95e-99ae2ddfcded", "AQAAAAIAAYagAAAAEACeXdFLr2cFOc7Qv9mklQVrEg4+Tr/ZNauuuBsLgbo2HZ7b4VMG0qms18STU3WtXw==", "ede61909-757e-4879-808d-bd1a5bd4a0ea" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("003e4c5e-dc8f-4420-9c4b-037cd42994e1"), 0, "70657844-5950-491e-b168-b7ffef6b9ae4", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("1d7649a6-d84e-4735-a99a-c890bbbbb2e0"), 0, "c9e536ea-6046-425c-8beb-e8a1b2d739fa", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" },
                    { new Guid("20945e7a-157d-487e-ae00-f23792d0dc75"), 0, "7f3d95fc-7d93-4d74-abee-dd4aafc2ae34", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("22053662-affa-4896-a475-d5d086861a72"), 0, "5f8eb7f4-40fd-4bc9-9fb1-0ee404a840ca", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("353df188-4ff4-46d7-9de9-be47c4e7dd2f"), 0, "98f8a59f-397b-42f3-b85c-dd70d97f175f", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("4c10dc95-4029-4313-b054-139035ae794b"), 0, "13c89f80-dd8d-4e64-b608-261af4c61e29", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" },
                    { new Guid("55820041-0dc2-4f0b-9b99-b12205c4b85d"), 0, "4c4ce6c0-3ec3-4a4c-983b-d803f74ea631", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" },
                    { new Guid("63c6ecaa-03a2-4018-83aa-456b4be0d599"), 0, "00c6a4b9-fd16-4b71-b07d-1f2cf3c44e8f", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" },
                    { new Guid("6de84357-01f4-4bca-ab09-5a57bfc51e62"), 0, "4378f0d0-81ec-4d71-9045-5be6e10f3e2b", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("9bb0854e-0b8f-4073-94f7-7ff6d5c2a56e"), 0, "f3778786-0e77-4a1b-8176-76622780f766", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("cdf8ea83-0886-43d3-839c-54f5e5bbd3aa"), 0, "7eb5c3fd-db68-42f0-8038-a5ddf3a09bda", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("d93991c1-b430-44ea-abf9-84c811629c9c"), 0, "1e81adb8-8312-43e6-8cbc-99ba27d1b566", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f8c6d6a-c24f-433f-be3b-ca89eee08c6d"), "Dermatology", new Guid("353df188-4ff4-46d7-9de9-be47c4e7dd2f") },
                    { new Guid("95a855b0-406b-442e-9291-1507eba7d431"), "Dermatology", new Guid("63c6ecaa-03a2-4018-83aa-456b4be0d599") },
                    { new Guid("bbfb56ba-5f60-413e-8319-f0dcf3fbacdf"), "Chiropractic", new Guid("55820041-0dc2-4f0b-9b99-b12205c4b85d") },
                    { new Guid("cfe370e4-a0f4-4378-a02f-4087a2e4c1e3"), "Dermatology", new Guid("4c10dc95-4029-4313-b054-139035ae794b") },
                    { new Guid("d19b2b10-01e2-4073-8598-030efcba4520"), "Cardiac Surgery", new Guid("9bb0854e-0b8f-4073-94f7-7ff6d5c2a56e") },
                    { new Guid("fbf44e0f-6967-4376-bca3-e06195f64e3a"), "Allergy", new Guid("1d7649a6-d84e-4735-a99a-c890bbbbb2e0") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("08b5b773-6780-4f1f-a6aa-9b244de0ddc3"), new Guid("22053662-affa-4896-a475-d5d086861a72") },
                    { new Guid("0a706d1d-b56e-4c10-b47c-11ebfa8d5d4d"), new Guid("20945e7a-157d-487e-ae00-f23792d0dc75") },
                    { new Guid("41334662-a41a-40f7-9342-2b7abccfd721"), new Guid("6de84357-01f4-4bca-ab09-5a57bfc51e62") },
                    { new Guid("6c845471-e1ea-4646-a4de-665f063ee3de"), new Guid("cdf8ea83-0886-43d3-839c-54f5e5bbd3aa") },
                    { new Guid("a7ad59f7-4a5b-4491-a5ed-bb38781d190f"), new Guid("d93991c1-b430-44ea-abf9-84c811629c9c") },
                    { new Guid("dff1a37e-db13-402a-9a11-b9c4877dbe91"), new Guid("003e4c5e-dc8f-4420-9c4b-037cd42994e1") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0f8c6d6a-c24f-433f-be3b-ca89eee08c6d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("95a855b0-406b-442e-9291-1507eba7d431"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("bbfb56ba-5f60-413e-8319-f0dcf3fbacdf"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cfe370e4-a0f4-4378-a02f-4087a2e4c1e3"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d19b2b10-01e2-4073-8598-030efcba4520"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("fbf44e0f-6967-4376-bca3-e06195f64e3a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("08b5b773-6780-4f1f-a6aa-9b244de0ddc3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("0a706d1d-b56e-4c10-b47c-11ebfa8d5d4d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("41334662-a41a-40f7-9342-2b7abccfd721"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6c845471-e1ea-4646-a4de-665f063ee3de"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a7ad59f7-4a5b-4491-a5ed-bb38781d190f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("dff1a37e-db13-402a-9a11-b9c4877dbe91"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("003e4c5e-dc8f-4420-9c4b-037cd42994e1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1d7649a6-d84e-4735-a99a-c890bbbbb2e0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("20945e7a-157d-487e-ae00-f23792d0dc75"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("22053662-affa-4896-a475-d5d086861a72"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("353df188-4ff4-46d7-9de9-be47c4e7dd2f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c10dc95-4029-4313-b054-139035ae794b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55820041-0dc2-4f0b-9b99-b12205c4b85d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("63c6ecaa-03a2-4018-83aa-456b4be0d599"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6de84357-01f4-4bca-ab09-5a57bfc51e62"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9bb0854e-0b8f-4073-94f7-7ff6d5c2a56e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cdf8ea83-0886-43d3-839c-54f5e5bbd3aa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d93991c1-b430-44ea-abf9-84c811629c9c"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5aa8ef93-ed15-46c0-8b24-14d0b22c2bf5", "AQAAAAIAAYagAAAAEFJwvTLFRUe8NaFwo85xDk7cVW6Epo0vLIudv0LsU3SHIWi2IKJPkpWOqY6zYhgpcw==", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("013624b8-db0f-4914-bb45-056dcc2fc9a4"), 0, "883f353c-4dac-45f5-a42a-030f9b0cb275", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("05718fd3-8a37-4d41-ae7d-1558cc1bb257"), 0, "67ac8a7d-1b72-4516-8359-4f1fa3735e03", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("0e2ede5c-d8d3-423b-83e8-b13da520df9c"), 0, "1261663e-e142-41e3-a2c7-6162cc71d578", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" },
                    { new Guid("231bc597-716d-4d2a-b9e3-10c0cf6e3dd3"), 0, "b204db06-8bf6-4c7d-97c9-34039b23949e", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("2d306ff7-1198-476d-abf4-4e584ca3f18e"), 0, "831ece01-fecd-4792-bfe3-6da5326386b7", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("526b6e2b-3c82-4c8d-9599-58c329dabc08"), 0, "12062b5c-ac21-4d06-ae9f-8f60e79ff359", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("5c82102b-ac17-4ec6-95e3-e8bfa2dc35c0"), 0, "247734fd-0753-44ef-9562-800b81c498fb", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" },
                    { new Guid("8f73ac20-a572-4fcb-a486-d29b49a77e85"), 0, "e6629662-6bc7-4c45-80bd-7d5bd8d9782f", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("adaab996-9cb1-420b-966e-08043cfbbf9f"), 0, "a417ec52-2fce-425a-9bae-302995ae0523", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" },
                    { new Guid("aecab71f-79a7-4265-b13f-ff76e833b370"), 0, "e0416a2a-9364-47d3-ab25-ee97d970a45f", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" },
                    { new Guid("b81eb3c1-bed1-4d41-90c1-1b3428dc7492"), 0, "a54c05cf-3aeb-43ab-82c1-fbf5e7e36831", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("e79b0f36-a642-44c0-afae-661336d7fcaf"), 0, "1513edbe-52d2-4024-bb1d-31aca10cf6bc", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("039ae53c-e632-49c8-b086-17cd2eef5962"), "Cardiac Surgery", new Guid("526b6e2b-3c82-4c8d-9599-58c329dabc08") },
                    { new Guid("2fe9bd40-5801-4f53-bff2-499c1ed85438"), "Dermatology", new Guid("b81eb3c1-bed1-4d41-90c1-1b3428dc7492") },
                    { new Guid("627e9014-aeda-4b79-a67b-e15f8a714f00"), "Dermatology", new Guid("aecab71f-79a7-4265-b13f-ff76e833b370") },
                    { new Guid("8d03cde7-7a38-47ea-ad7f-0b27f2eed675"), "Chiropractic", new Guid("0e2ede5c-d8d3-423b-83e8-b13da520df9c") },
                    { new Guid("da451dad-ac46-4d74-9bae-69ad16057ec7"), "Allergy", new Guid("adaab996-9cb1-420b-966e-08043cfbbf9f") },
                    { new Guid("dc76db08-15d4-4a9f-84cf-08a768bc4b1a"), "Dermatology", new Guid("5c82102b-ac17-4ec6-95e3-e8bfa2dc35c0") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("738e2436-4b3b-4086-96d2-54026b6632b8"), new Guid("8f73ac20-a572-4fcb-a486-d29b49a77e85") },
                    { new Guid("8eb7cab2-4022-4f24-8a67-9fad20ccfbe3"), new Guid("013624b8-db0f-4914-bb45-056dcc2fc9a4") },
                    { new Guid("920dff7e-8750-4bb9-9261-03c4b2143069"), new Guid("05718fd3-8a37-4d41-ae7d-1558cc1bb257") },
                    { new Guid("934de294-2b12-42b1-b9b9-8393e214e56c"), new Guid("231bc597-716d-4d2a-b9e3-10c0cf6e3dd3") },
                    { new Guid("e5d9a825-7536-4fe4-8977-7d6ddb820b66"), new Guid("2d306ff7-1198-476d-abf4-4e584ca3f18e") },
                    { new Guid("f20645ae-f49e-4c27-bbc6-b900a54d01e8"), new Guid("e79b0f36-a642-44c0-afae-661336d7fcaf") }
                });
        }
    }
}
