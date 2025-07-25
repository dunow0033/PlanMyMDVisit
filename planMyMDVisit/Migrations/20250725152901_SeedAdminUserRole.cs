using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"), new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89940740-f6bf-4212-9e1e-d9bd26f75b60", "AQAAAAIAAYagAAAAEJJ/+plseuNyv/qfeitjKwJ0nQ0SWqlWUH28fyvFTc5SDKk73A6km5RaPBbRyzYD0A==", "2d884d33-9c41-4f38-8938-4438fe2f6418" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("19440123-ef6c-48d0-93bb-9641477449e9"), 0, "af3f3f64-d53a-4954-b8b4-e6927b39a1e3", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("41e41fd1-3e3c-4034-8b64-961e390a60db"), 0, "f6bc8672-a2df-489c-a6e1-f62afee9da25", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" },
                    { new Guid("4f495676-d019-43c5-bf25-6d2dc9f42582"), 0, "9a8d661d-236c-4c55-8574-359ff57ff2e2", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("6e03b173-79ec-4cbe-b5c4-886529bf626c"), 0, "4b975a91-0cdc-4ab2-9ff0-c2f728faf342", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("79599770-0a67-49db-bdac-387664a0f903"), 0, "6b0dcdec-5efc-4c76-8943-2d0b1071d0aa", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" },
                    { new Guid("88db311b-fb11-406e-bad9-b5df990c12a6"), 0, "c1620f27-ee24-4b3d-9817-0a0f893b7ce2", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("89750140-1a79-41cb-bacd-f37e82739736"), 0, "108165ae-3a51-4932-8b3b-ce191eddb190", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("8cea0243-6898-4139-afbc-a813baf042f4"), 0, "fab68802-6ea9-401a-ba11-00c0dbee2fc1", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("929aecc2-176d-4355-b52d-8373b0d9b86f"), 0, "df3511db-f08f-443a-8af1-fccb78e35298", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("961e2801-b07c-4c4e-b7a1-49068a05f767"), 0, "52886553-5234-48aa-b303-0482e8164452", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" },
                    { new Guid("ad882311-6514-40a3-a88d-d5ae20dd0a6d"), 0, "b3fabdac-6a8b-494a-a7ad-8350f7987a02", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("b8b7ffe3-7395-436a-b67b-43f643dbf1c1"), 0, "149ebc0c-8f27-42ed-9e7d-e43184873284", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("470fae52-3ea8-40b3-95d6-8a6378249d48"), "Chiropractic", new Guid("41e41fd1-3e3c-4034-8b64-961e390a60db") },
                    { new Guid("4934aec0-4944-433a-be99-a1afdafaf634"), "Dermatology", new Guid("4f495676-d019-43c5-bf25-6d2dc9f42582") },
                    { new Guid("5075f7cd-5a7f-40fb-bfa6-cd4e27efad43"), "Dermatology", new Guid("79599770-0a67-49db-bdac-387664a0f903") },
                    { new Guid("6395e09e-90de-48a5-be4e-eccfc6f00530"), "Cardiac Surgery", new Guid("929aecc2-176d-4355-b52d-8373b0d9b86f") },
                    { new Guid("69414c0d-307b-4daf-8e33-44fd9a268b37"), "Allergy", new Guid("961e2801-b07c-4c4e-b7a1-49068a05f767") },
                    { new Guid("8adbce5b-bfa6-4870-9594-b0bd43491488"), "Dermatology", new Guid("b8b7ffe3-7395-436a-b67b-43f643dbf1c1") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("42ada5e6-ba16-4328-bfa7-f52a7e2b26dd"), new Guid("89750140-1a79-41cb-bacd-f37e82739736") },
                    { new Guid("4a091a86-4bfd-473f-a5e5-434f67dccdad"), new Guid("6e03b173-79ec-4cbe-b5c4-886529bf626c") },
                    { new Guid("6de10f30-4a65-488d-86c3-e562f19c9fc8"), new Guid("88db311b-fb11-406e-bad9-b5df990c12a6") },
                    { new Guid("7d849fa4-4a47-4b27-8877-04bc19844f8d"), new Guid("ad882311-6514-40a3-a88d-d5ae20dd0a6d") },
                    { new Guid("a72a7507-ee34-4a47-9cc1-190e29eadb7c"), new Guid("8cea0243-6898-4139-afbc-a813baf042f4") },
                    { new Guid("ab6e51b8-29d5-4845-b84d-9f7a0bcc10e5"), new Guid("19440123-ef6c-48d0-93bb-9641477449e9") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"), new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d") });

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("470fae52-3ea8-40b3-95d6-8a6378249d48"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4934aec0-4944-433a-be99-a1afdafaf634"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5075f7cd-5a7f-40fb-bfa6-cd4e27efad43"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6395e09e-90de-48a5-be4e-eccfc6f00530"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("69414c0d-307b-4daf-8e33-44fd9a268b37"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8adbce5b-bfa6-4870-9594-b0bd43491488"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("42ada5e6-ba16-4328-bfa7-f52a7e2b26dd"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4a091a86-4bfd-473f-a5e5-434f67dccdad"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6de10f30-4a65-488d-86c3-e562f19c9fc8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7d849fa4-4a47-4b27-8877-04bc19844f8d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a72a7507-ee34-4a47-9cc1-190e29eadb7c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ab6e51b8-29d5-4845-b84d-9f7a0bcc10e5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("19440123-ef6c-48d0-93bb-9641477449e9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("41e41fd1-3e3c-4034-8b64-961e390a60db"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4f495676-d019-43c5-bf25-6d2dc9f42582"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e03b173-79ec-4cbe-b5c4-886529bf626c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("79599770-0a67-49db-bdac-387664a0f903"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88db311b-fb11-406e-bad9-b5df990c12a6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("89750140-1a79-41cb-bacd-f37e82739736"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8cea0243-6898-4139-afbc-a813baf042f4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("929aecc2-176d-4355-b52d-8373b0d9b86f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("961e2801-b07c-4c4e-b7a1-49068a05f767"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad882311-6514-40a3-a88d-d5ae20dd0a6d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8b7ffe3-7395-436a-b67b-43f643dbf1c1"));

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
    }
}
