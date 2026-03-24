using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class addingcertainfieldsforthePatientmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1f3be87c-f7a5-45b0-9bb7-e3730cb414a3"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6f92636e-7bd0-4bd1-b1bf-6b79fe9de5f5"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a49700fb-56a3-450d-8d44-3585cdb3e68e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ca93f0aa-2f77-4ab9-a96f-8e8af7173394"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e12de560-f1b0-4ca5-bb1e-7846d8c3da53"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e2d71860-2275-4e61-a243-0f4c63d6ae87"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4c7c450f-074d-4c4f-bf0d-076128d5b33d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("5379ef14-48fe-4057-9e45-a86440ab2967"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("67024054-0e9b-4969-888b-b69b1c49e0e3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7f01703c-4be7-44bc-a040-4c73d6f0623b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("8ef825b8-b79c-4dd2-9108-7648f1234383"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("cb6c6eef-96de-4db4-b2f1-73ae1aa3e333"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1c3ce4d1-298c-418c-9739-1b8f5cc0d1bd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2f4bccb9-78fb-4e55-b967-12c39bc312fd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("52db7ad6-da78-4133-b0e6-e5112fa3bafe"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6476b630-be9e-449c-8ddb-1aae5100d484"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("81e7b3cf-9736-431a-a463-53c2604585e9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9e95172e-cb78-4a85-a7da-2c2241f2c73c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f1a6706-3310-490f-8ed4-074643bffb29"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a67078e9-86f3-4498-985c-45a7462ecf12"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf7e853c-cff2-4e68-8476-bebf1b7a0e2b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dd47c7b5-4077-4150-957f-302d461a1a32"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e864e45e-0ca2-4802-a6d4-1969a95d4b88"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e8d57533-46d1-4993-9158-dee8d2974914"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e750ec87-5fa2-4b6d-b865-0959ad5155d3", "AQAAAAIAAYagAAAAEO5gKvRXYPycTd8wUISjy+kKhTBcaY57ccqO1dxs08XX4ZK74vMLsAu8IyvOUkQIWA==", "d0b9f6bf-5f30-4e68-88f7-96320354dcd9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Admin", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("10d6e80d-7b04-41db-b792-3ce6d5f003a0"), 0, false, "872ec690-b8e8-40b2-8114-53a66cfb422c", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("2248a98d-a7ce-46c5-89fe-a034cd42ac95"), 0, false, "96513482-df98-43c5-a0aa-493c8f0768b6", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("22aa96df-7056-4d8e-a32c-2696b0e86635"), 0, false, "71ad1fdc-149d-44a3-b38f-9c18930a5e57", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("384b0099-882a-43d6-ae17-c17904713ff3"), 0, false, "2d862a2a-315b-481a-9016-c425d13d37f8", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("3dc092d7-955c-4c07-b884-72a9c8ed518d"), 0, false, "fc16f8f6-e296-4c18-886a-efea84becb47", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("415d9118-9e5d-41c0-b1c6-30dc250b782f"), 0, false, "36f2c132-bbbe-4c77-ba5a-f2995a2e79f1", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("5fd7d29f-5fc7-4851-bca0-883769221b56"), 0, false, "63ebc71f-9215-4a51-a1fb-15e8279967d9", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("7a120b54-98a8-4668-9da1-cf01b6e87ca8"), 0, false, "63890a6c-d66e-488d-a628-54880a99e1f1", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("9c103379-583d-4210-a14b-5ed8e9814247"), 0, false, "d0462146-bae6-4144-af52-cb68589ffdad", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" },
                    { new Guid("b6e16984-9dea-4085-aa5d-03f00fba23d3"), 0, false, "76d4fae3-47c8-470e-8a38-8e67f96be9b8", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" },
                    { new Guid("db49420b-0a31-476f-bac4-3bd24530c95b"), 0, false, "cf0bca64-901d-4cf8-874f-d4682577bbc2", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" },
                    { new Guid("e94079be-afaa-432a-839b-98f6516a9362"), 0, false, "91a15df3-90ab-40c3-8c2e-0eab018f9062", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("4cc3ac9e-7657-4978-99ba-38e5d626af22"), "Dermatology", new Guid("e94079be-afaa-432a-839b-98f6516a9362") },
                    { new Guid("61e81758-8665-47a1-ae61-688edad73144"), "Cardiac Surgery", new Guid("5fd7d29f-5fc7-4851-bca0-883769221b56") },
                    { new Guid("64e013e0-8e68-4038-b0ff-b9662d6ee16c"), "Chiropractic", new Guid("9c103379-583d-4210-a14b-5ed8e9814247") },
                    { new Guid("9e74433a-b00e-481d-bdc2-94b597588ca1"), "Allergy", new Guid("db49420b-0a31-476f-bac4-3bd24530c95b") },
                    { new Guid("cd68a3f9-1cc8-4911-83a8-1971328873a5"), "Dermatology", new Guid("b6e16984-9dea-4085-aa5d-03f00fba23d3") },
                    { new Guid("f089450c-3df3-4bce-98c1-2a8437bfd7a2"), "Dermatology", new Guid("415d9118-9e5d-41c0-b1c6-30dc250b782f") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId", "medicalRecord", "medications", "testResults" },
                values: new object[,]
                {
                    { new Guid("4ba32ff4-afab-41e1-a9aa-6d54a9b199d5"), new Guid("2248a98d-a7ce-46c5-89fe-a034cd42ac95"), null, null, null },
                    { new Guid("5ef8cd4c-ebd5-4969-b00b-7b4b3740ea77"), new Guid("384b0099-882a-43d6-ae17-c17904713ff3"), null, null, null },
                    { new Guid("8e2f3e39-bee6-47db-be19-8172fd4c2116"), new Guid("22aa96df-7056-4d8e-a32c-2696b0e86635"), null, null, null },
                    { new Guid("a8dc8611-75e1-4068-b85b-75e10aacd89f"), new Guid("10d6e80d-7b04-41db-b792-3ce6d5f003a0"), null, null, null },
                    { new Guid("d15ee1d2-a7b6-415f-89f6-8511ee68c6a0"), new Guid("3dc092d7-955c-4c07-b884-72a9c8ed518d"), null, null, null },
                    { new Guid("f80457c5-064f-4423-a714-1e3f2e828154"), new Guid("7a120b54-98a8-4668-9da1-cf01b6e87ca8"), null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4cc3ac9e-7657-4978-99ba-38e5d626af22"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("61e81758-8665-47a1-ae61-688edad73144"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("64e013e0-8e68-4038-b0ff-b9662d6ee16c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9e74433a-b00e-481d-bdc2-94b597588ca1"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cd68a3f9-1cc8-4911-83a8-1971328873a5"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f089450c-3df3-4bce-98c1-2a8437bfd7a2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4ba32ff4-afab-41e1-a9aa-6d54a9b199d5"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("5ef8cd4c-ebd5-4969-b00b-7b4b3740ea77"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("8e2f3e39-bee6-47db-be19-8172fd4c2116"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a8dc8611-75e1-4068-b85b-75e10aacd89f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d15ee1d2-a7b6-415f-89f6-8511ee68c6a0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f80457c5-064f-4423-a714-1e3f2e828154"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("10d6e80d-7b04-41db-b792-3ce6d5f003a0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2248a98d-a7ce-46c5-89fe-a034cd42ac95"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("22aa96df-7056-4d8e-a32c-2696b0e86635"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("384b0099-882a-43d6-ae17-c17904713ff3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3dc092d7-955c-4c07-b884-72a9c8ed518d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("415d9118-9e5d-41c0-b1c6-30dc250b782f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5fd7d29f-5fc7-4851-bca0-883769221b56"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a120b54-98a8-4668-9da1-cf01b6e87ca8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9c103379-583d-4210-a14b-5ed8e9814247"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6e16984-9dea-4085-aa5d-03f00fba23d3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db49420b-0a31-476f-bac4-3bd24530c95b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e94079be-afaa-432a-839b-98f6516a9362"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5baf15a-b798-4768-80ec-4a40e09f2f1c", "AQAAAAIAAYagAAAAEB2gWEmSmbsdeAQe1Eq9Vh7TenzUpypgUFklwJZKX3O+OgG1NNali8fefoNmOTulqQ==", "84634904-8f35-4bc0-a554-171e6c08b5f2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Admin", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("1c3ce4d1-298c-418c-9739-1b8f5cc0d1bd"), 0, false, "31055dc0-b038-4317-a2fe-466b2bc3e064", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("2f4bccb9-78fb-4e55-b967-12c39bc312fd"), 0, false, "237dec9d-9e4f-42c8-a511-60f0486df6f3", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" },
                    { new Guid("52db7ad6-da78-4133-b0e6-e5112fa3bafe"), 0, false, "c09da8fb-1039-446d-ba90-7cc2dd0ef2d1", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("6476b630-be9e-449c-8ddb-1aae5100d484"), 0, false, "eee0a0f6-0cba-49f5-8fb2-66eefc8ed513", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("81e7b3cf-9736-431a-a463-53c2604585e9"), 0, false, "0d954d94-2a70-4ad7-98bc-3d5575748c45", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("9e95172e-cb78-4a85-a7da-2c2241f2c73c"), 0, false, "f6864628-1e5a-48a6-8034-9baef5fa9835", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("9f1a6706-3310-490f-8ed4-074643bffb29"), 0, false, "ff54991d-2d69-4ab4-beb2-33b7a794c423", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("a67078e9-86f3-4498-985c-45a7462ecf12"), 0, false, "59f0f192-a1c7-4e7d-8844-35cbebf30afa", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" },
                    { new Guid("cf7e853c-cff2-4e68-8476-bebf1b7a0e2b"), 0, false, "e279db59-04fb-4c88-9426-cd6edbc3b37a", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("dd47c7b5-4077-4150-957f-302d461a1a32"), 0, false, "2eb2f2bd-1842-4399-b8ee-31fdd0a40431", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("e864e45e-0ca2-4802-a6d4-1969a95d4b88"), 0, false, "dcf8ca91-5a56-4bef-8c4c-93cfb7b7a0e4", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" },
                    { new Guid("e8d57533-46d1-4993-9158-dee8d2974914"), 0, false, "ab8696e5-0364-4f2a-a99d-ff06f4f53ee5", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("1f3be87c-f7a5-45b0-9bb7-e3730cb414a3"), "Dermatology", new Guid("81e7b3cf-9736-431a-a463-53c2604585e9") },
                    { new Guid("6f92636e-7bd0-4bd1-b1bf-6b79fe9de5f5"), "Chiropractic", new Guid("e864e45e-0ca2-4802-a6d4-1969a95d4b88") },
                    { new Guid("a49700fb-56a3-450d-8d44-3585cdb3e68e"), "Dermatology", new Guid("a67078e9-86f3-4498-985c-45a7462ecf12") },
                    { new Guid("ca93f0aa-2f77-4ab9-a96f-8e8af7173394"), "Cardiac Surgery", new Guid("cf7e853c-cff2-4e68-8476-bebf1b7a0e2b") },
                    { new Guid("e12de560-f1b0-4ca5-bb1e-7846d8c3da53"), "Allergy", new Guid("2f4bccb9-78fb-4e55-b967-12c39bc312fd") },
                    { new Guid("e2d71860-2275-4e61-a243-0f4c63d6ae87"), "Dermatology", new Guid("e8d57533-46d1-4993-9158-dee8d2974914") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId", "medicalRecord", "medications", "testResults" },
                values: new object[,]
                {
                    { new Guid("4c7c450f-074d-4c4f-bf0d-076128d5b33d"), new Guid("dd47c7b5-4077-4150-957f-302d461a1a32"), null, null, null },
                    { new Guid("5379ef14-48fe-4057-9e45-a86440ab2967"), new Guid("52db7ad6-da78-4133-b0e6-e5112fa3bafe"), null, null, null },
                    { new Guid("67024054-0e9b-4969-888b-b69b1c49e0e3"), new Guid("9e95172e-cb78-4a85-a7da-2c2241f2c73c"), null, null, null },
                    { new Guid("7f01703c-4be7-44bc-a040-4c73d6f0623b"), new Guid("9f1a6706-3310-490f-8ed4-074643bffb29"), null, null, null },
                    { new Guid("8ef825b8-b79c-4dd2-9108-7648f1234383"), new Guid("1c3ce4d1-298c-418c-9739-1b8f5cc0d1bd"), null, null, null },
                    { new Guid("cb6c6eef-96de-4db4-b2f1-73ae1aa3e333"), new Guid("6476b630-be9e-449c-8ddb-1aae5100d484"), null, null, null }
                });
        }
    }
}
