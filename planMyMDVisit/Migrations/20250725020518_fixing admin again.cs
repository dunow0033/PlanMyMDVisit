using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class fixingadminagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0928f630-dd6e-42a7-884c-88d245b7b12f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("12f743ed-5baf-4c48-9b62-ea61d67d6213"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("22ad76b6-002a-4a40-8642-11ce0aafd704"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7bbd2188-86e9-4994-a4f0-a7e5f7f23672"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c07bfd1f-2354-4a0f-899b-90ef844f44f4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e74be87c-31ff-44c7-ae38-8f5d7acfaf35"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1869702a-88bf-4f32-8c92-158b64036cdb"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1a3c756a-118b-490e-a9f6-8da4b0b923b4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2d69aa50-fd53-46cc-b595-3495d7457562"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("b997e161-7bc9-44c7-97fc-9aa2b1467432"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d7dff7e4-4ec9-4beb-a8c9-eb04a025375c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ffb8b9bb-bcba-4959-9026-252874c8681f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("06ad1d69-c59d-44b3-bee1-a4e4d105e918"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ea6d2ee-0f47-412a-9b7f-23e7d609fca2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("27568fdc-700c-4824-a741-4c470db8499d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("45ebe2e2-9e7b-4c74-a8ee-35aafd8eb0b1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("856241a5-cfea-451a-aff4-a8b74125860c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a22959d-3573-4c3a-a2e7-f080c0210bfc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8f4d5e82-651c-43be-981e-e2ef873eaf29"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9004c9c1-5e07-4663-843e-f05ae05c5268"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b49345f1-baf0-498a-afa2-30d5db3b46ce"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c79daeac-549d-420d-9372-c0fe5cf4807c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f310d354-e77b-4d21-b18f-994401a34858"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ffc4444b-ec35-43c3-bc1d-deb712f60bec"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "5aa8ef93-ed15-46c0-8b24-14d0b22c2bf5", "ADMIN", "AQAAAAIAAYagAAAAEFJwvTLFRUe8NaFwo85xDk7cVW6Epo0vLIudv0LsU3SHIWi2IKJPkpWOqY6zYhgpcw==" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "536d1061-52dd-4f6d-af91-293a704eddfb", "ADMIN@PLANMYMD.COM", "AQAAAAIAAYagAAAAENd8KyQ9gmNtXPhWzE6w2q82PAenm+2OQBxifB0If9DKPBrngJcl+TBLK493mrr2Ow==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("06ad1d69-c59d-44b3-bee1-a4e4d105e918"), 0, "2434ec57-a4b4-468b-b9c0-db77759d84c9", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("0ea6d2ee-0f47-412a-9b7f-23e7d609fca2"), 0, "59ae7abc-5f62-4725-8ad3-febf0ef07d1c", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("27568fdc-700c-4824-a741-4c470db8499d"), 0, "97308b52-092f-4f9b-8f1d-5525f4b083f8", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("45ebe2e2-9e7b-4c74-a8ee-35aafd8eb0b1"), 0, "add73353-c8ef-4661-9116-ba5632f0cc08", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" },
                    { new Guid("856241a5-cfea-451a-aff4-a8b74125860c"), 0, "3fe6b96c-92bd-47a0-a20c-4e5c2e047b7c", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("8a22959d-3573-4c3a-a2e7-f080c0210bfc"), 0, "6197fe7f-c01c-4be4-8292-86064a758c02", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("8f4d5e82-651c-43be-981e-e2ef873eaf29"), 0, "e7bc3750-8e7c-4560-880b-75da6158fbc1", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("9004c9c1-5e07-4663-843e-f05ae05c5268"), 0, "cb655b85-042d-4950-91d3-0c90665b2460", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" },
                    { new Guid("b49345f1-baf0-498a-afa2-30d5db3b46ce"), 0, "91930a14-aa81-4706-abae-5b8c23a15054", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("c79daeac-549d-420d-9372-c0fe5cf4807c"), 0, "6bebbe1b-27b1-4528-84b4-ef9ffbed8b72", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" },
                    { new Guid("f310d354-e77b-4d21-b18f-994401a34858"), 0, "144cf70b-1f81-45fd-968d-705e4e1cc839", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("ffc4444b-ec35-43c3-bc1d-deb712f60bec"), 0, "d4a5f681-6d34-4bbf-9d01-3290449c61a5", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("0928f630-dd6e-42a7-884c-88d245b7b12f"), "Dermatology", new Guid("b49345f1-baf0-498a-afa2-30d5db3b46ce") },
                    { new Guid("12f743ed-5baf-4c48-9b62-ea61d67d6213"), "Dermatology", new Guid("9004c9c1-5e07-4663-843e-f05ae05c5268") },
                    { new Guid("22ad76b6-002a-4a40-8642-11ce0aafd704"), "Cardiac Surgery", new Guid("27568fdc-700c-4824-a741-4c470db8499d") },
                    { new Guid("7bbd2188-86e9-4994-a4f0-a7e5f7f23672"), "Allergy", new Guid("ffc4444b-ec35-43c3-bc1d-deb712f60bec") },
                    { new Guid("c07bfd1f-2354-4a0f-899b-90ef844f44f4"), "Dermatology", new Guid("c79daeac-549d-420d-9372-c0fe5cf4807c") },
                    { new Guid("e74be87c-31ff-44c7-ae38-8f5d7acfaf35"), "Chiropractic", new Guid("45ebe2e2-9e7b-4c74-a8ee-35aafd8eb0b1") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("1869702a-88bf-4f32-8c92-158b64036cdb"), new Guid("f310d354-e77b-4d21-b18f-994401a34858") },
                    { new Guid("1a3c756a-118b-490e-a9f6-8da4b0b923b4"), new Guid("06ad1d69-c59d-44b3-bee1-a4e4d105e918") },
                    { new Guid("2d69aa50-fd53-46cc-b595-3495d7457562"), new Guid("8f4d5e82-651c-43be-981e-e2ef873eaf29") },
                    { new Guid("b997e161-7bc9-44c7-97fc-9aa2b1467432"), new Guid("8a22959d-3573-4c3a-a2e7-f080c0210bfc") },
                    { new Guid("d7dff7e4-4ec9-4beb-a8c9-eb04a025375c"), new Guid("856241a5-cfea-451a-aff4-a8b74125860c") },
                    { new Guid("ffb8b9bb-bcba-4959-9026-252874c8681f"), new Guid("0ea6d2ee-0f47-412a-9b7f-23e7d609fca2") }
                });
        }
    }
}
