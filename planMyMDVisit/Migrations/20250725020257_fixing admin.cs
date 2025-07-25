using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class fixingadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2202bda2-2fb6-4d3d-8e46-0138c69ed8d6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2e542e61-18a1-4268-9cc8-6306b846d2ea"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4768ec86-9fc6-4587-b037-ef1e83f913ab"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7e96f507-f7bc-46de-a40a-d1e8122b8ac7"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("bab27d98-34cc-4e93-80fc-2423e3a9c289"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("da73c825-44d8-4eb3-92c2-c1acf6f8d6a1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2ab2c6b8-0a57-4178-bbf1-4db18b40fa84"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3eaf37ec-26cd-4154-8e81-1b9b48adce8c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7427dbb3-24a1-4b39-85d3-9ad5dd8c9446"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("936a3df5-3a2d-45bf-b296-097c21c122b3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ef2c7b0b-d57a-40c6-951e-de43e8923612"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f8c44b63-ae05-4e00-aa49-1c7aff179a12"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19905a09-5e24-4537-a73a-8cfd67f690ff"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("31b695b0-7202-496e-ae64-26f083e6f3b5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("33a1a8b8-8fa7-42e4-8a14-63ff2ba07d27"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3a4df621-fc4d-4902-a11b-9fdf9937f832"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("78fd81f6-4f93-405a-9c8a-be2f4fe3cceb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a94bbe4-e529-47b6-9c95-86829197dfc7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ae05bdf8-a24f-4918-b250-4d0b6a3ed2a5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b0dead9b-bd5a-4195-b9a1-fdb09f9963b3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6c10c83-a67c-43fd-b82c-05adf1acd0c6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d5fb0a93-965c-430c-8328-e3fac8297796"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("de14ae97-290b-4df0-9dcc-c54693de2f2b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e4006c86-1bbc-4682-96f9-cddd007ba639"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "DoctorOrPatient", "PasswordHash" },
                values: new object[] { "536d1061-52dd-4f6d-af91-293a704eddfb", "admin", "AQAAAAIAAYagAAAAENd8KyQ9gmNtXPhWzE6w2q82PAenm+2OQBxifB0If9DKPBrngJcl+TBLK493mrr2Ow==" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "DoctorOrPatient", "PasswordHash" },
                values: new object[] { "e54b0c92-30c9-4a20-a907-11e90656a3ac", null, "AQAAAAIAAYagAAAAEEJB3sxMD1lN+JcPyFE/ACU/J7QKkUCbSUZj5yEOXXvjFCoTyN5vaYDj+/ywFSiZQA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("19905a09-5e24-4537-a73a-8cfd67f690ff"), 0, "0ba6f472-f769-4431-b992-7a4bd04ebe27", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("31b695b0-7202-496e-ae64-26f083e6f3b5"), 0, "217a87ff-ef95-47a9-8733-4c39b16254f8", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("33a1a8b8-8fa7-42e4-8a14-63ff2ba07d27"), 0, "be2fdd38-5c73-4fe2-81a6-cf348b797253", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("3a4df621-fc4d-4902-a11b-9fdf9937f832"), 0, "f5aca1e0-72f8-4b3f-b915-6fb12ce86142", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("78fd81f6-4f93-405a-9c8a-be2f4fe3cceb"), 0, "311df731-c22c-4c74-91af-fed6d617febd", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" },
                    { new Guid("7a94bbe4-e529-47b6-9c95-86829197dfc7"), 0, "c25ed1cc-02fc-4523-a51b-4b56e791554a", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("ae05bdf8-a24f-4918-b250-4d0b6a3ed2a5"), 0, "761c94bd-05a3-4a9f-9a9e-246637ce0543", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("b0dead9b-bd5a-4195-b9a1-fdb09f9963b3"), 0, "aa81b439-4b12-4825-b001-52bf23160dd7", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" },
                    { new Guid("c6c10c83-a67c-43fd-b82c-05adf1acd0c6"), 0, "385fbcfd-bc8f-4261-9357-30aeff5641e9", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" },
                    { new Guid("d5fb0a93-965c-430c-8328-e3fac8297796"), 0, "fbab5570-bbeb-4160-bbdc-52bf40364fb4", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("de14ae97-290b-4df0-9dcc-c54693de2f2b"), 0, "d84e623a-1335-4d0e-a1f5-1e1863c314f7", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" },
                    { new Guid("e4006c86-1bbc-4682-96f9-cddd007ba639"), 0, "d526c986-cec7-4f44-9dba-2deac04d9db4", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("2202bda2-2fb6-4d3d-8e46-0138c69ed8d6"), "Dermatology", new Guid("78fd81f6-4f93-405a-9c8a-be2f4fe3cceb") },
                    { new Guid("2e542e61-18a1-4268-9cc8-6306b846d2ea"), "Dermatology", new Guid("de14ae97-290b-4df0-9dcc-c54693de2f2b") },
                    { new Guid("4768ec86-9fc6-4587-b037-ef1e83f913ab"), "Dermatology", new Guid("d5fb0a93-965c-430c-8328-e3fac8297796") },
                    { new Guid("7e96f507-f7bc-46de-a40a-d1e8122b8ac7"), "Cardiac Surgery", new Guid("19905a09-5e24-4537-a73a-8cfd67f690ff") },
                    { new Guid("bab27d98-34cc-4e93-80fc-2423e3a9c289"), "Chiropractic", new Guid("b0dead9b-bd5a-4195-b9a1-fdb09f9963b3") },
                    { new Guid("da73c825-44d8-4eb3-92c2-c1acf6f8d6a1"), "Allergy", new Guid("c6c10c83-a67c-43fd-b82c-05adf1acd0c6") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("2ab2c6b8-0a57-4178-bbf1-4db18b40fa84"), new Guid("31b695b0-7202-496e-ae64-26f083e6f3b5") },
                    { new Guid("3eaf37ec-26cd-4154-8e81-1b9b48adce8c"), new Guid("33a1a8b8-8fa7-42e4-8a14-63ff2ba07d27") },
                    { new Guid("7427dbb3-24a1-4b39-85d3-9ad5dd8c9446"), new Guid("3a4df621-fc4d-4902-a11b-9fdf9937f832") },
                    { new Guid("936a3df5-3a2d-45bf-b296-097c21c122b3"), new Guid("7a94bbe4-e529-47b6-9c95-86829197dfc7") },
                    { new Guid("ef2c7b0b-d57a-40c6-951e-de43e8923612"), new Guid("e4006c86-1bbc-4682-96f9-cddd007ba639") },
                    { new Guid("f8c44b63-ae05-4e00-aa49-1c7aff179a12"), new Guid("ae05bdf8-a24f-4918-b250-4d0b6a3ed2a5") }
                });
        }
    }
}
