using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class addingcreatedatandupdatedat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("165d9a93-ac34-462d-912a-f82e23e7d1fe"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2d44f813-3ca4-4c6f-ac67-e5913105523b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5b4e5a28-2acc-4053-8398-8f0aa3b37548"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8543eeef-46d4-4716-be26-51f5dab76d6c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ba2ec211-b7f4-4f83-a83e-edcab8a159f6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("bb0a0c7a-2176-4897-b658-089de854804c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3e55ccea-3d7e-4c1b-889b-d26b9801a01d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("46959aef-4b05-4b46-b4bb-224e404e35d4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4e3cab16-bc26-48fc-b22c-7e19f7f52593"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("52575b0b-39bd-4cb2-a1cb-03b3b15955ca"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7a8797a4-cb8f-4e10-87be-1ef1f26dcfac"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7bff02db-9e88-4390-a1a3-799c1bfdcec5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12b84248-9af0-4e52-b155-16b9ea8d89b5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1af24b78-4f26-4d36-9784-a900d9fa5f2e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("29ac5d41-0fd2-4ee7-b6e9-bad3d7cc7168"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("49571e2a-5cb8-4824-80a2-98be323b88b7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5209d3ac-b15a-4cea-ab3d-7c5793f4ee7e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("546eb681-52dd-48df-9a9a-10c2613776f5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("69159b70-cda1-4da1-bb6f-51c91f44e2cd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b022c5a-8ed3-478b-8188-7ebf22bbf6ec"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9051a8c9-6376-4be0-9fcb-e1f82b34d37e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf54f1f5-246f-4948-8a65-d4cdcbff4f37"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f9ed7116-acfa-4089-9938-14230f1fa1b5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fdbb095e-eace-4498-bde2-b5fe4ae337a8"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "SYSUTCDATETIME()");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Patients",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "SYSUTCDATETIME()");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Patients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1171266-7997-48fc-8df6-9dd984c64880", "AQAAAAIAAYagAAAAEE2TMJ2r9MmrUSsVGwLm9+j0GvUiJ4D8Ec4BM7kQQb9thC4GWxaoKS09f2+UX7575w==", "15fec483-963a-47be-a7d3-d5eff3bc7c88" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Admin", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("12b84248-9af0-4e52-b155-16b9ea8d89b5"), 0, false, "6fdb3348-6744-443f-83e8-1f3b8dd759bf", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("1af24b78-4f26-4d36-9784-a900d9fa5f2e"), 0, false, "7750d014-9705-4aab-9ca8-3ff84d2d1098", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" },
                    { new Guid("29ac5d41-0fd2-4ee7-b6e9-bad3d7cc7168"), 0, false, "a6c8b301-0891-4663-842f-ab472e638a79", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("49571e2a-5cb8-4824-80a2-98be323b88b7"), 0, false, "de1e80f6-f34a-40b1-84ff-80ac5db448cf", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("5209d3ac-b15a-4cea-ab3d-7c5793f4ee7e"), 0, false, "94be5c34-47e7-44e7-83ab-0aaf43596046", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("546eb681-52dd-48df-9a9a-10c2613776f5"), 0, false, "bfe30730-d60f-48ed-9092-0a6394e47e08", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" },
                    { new Guid("69159b70-cda1-4da1-bb6f-51c91f44e2cd"), 0, false, "932834fe-ef1b-4632-8965-3cea8ace8eaf", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("6b022c5a-8ed3-478b-8188-7ebf22bbf6ec"), 0, false, "87f326d6-2657-48ff-9a9e-b7fa9d74fd18", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("9051a8c9-6376-4be0-9fcb-e1f82b34d37e"), 0, false, "6622098e-6bcc-4e7c-93a2-2fbfa7c1ce10", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("cf54f1f5-246f-4948-8a65-d4cdcbff4f37"), 0, false, "8a379ba3-315c-4ecd-b4b4-9cf8b528d21f", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("f9ed7116-acfa-4089-9938-14230f1fa1b5"), 0, false, "8ecb27a4-a5fd-4095-b696-5a8a7f9ce9d5", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" },
                    { new Guid("fdbb095e-eace-4498-bde2-b5fe4ae337a8"), 0, false, "0b254e1a-ea2f-4cc3-8ee0-c5d96274e232", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("165d9a93-ac34-462d-912a-f82e23e7d1fe"), "Allergy", new Guid("546eb681-52dd-48df-9a9a-10c2613776f5") },
                    { new Guid("2d44f813-3ca4-4c6f-ac67-e5913105523b"), "Dermatology", new Guid("1af24b78-4f26-4d36-9784-a900d9fa5f2e") },
                    { new Guid("5b4e5a28-2acc-4053-8398-8f0aa3b37548"), "Dermatology", new Guid("fdbb095e-eace-4498-bde2-b5fe4ae337a8") },
                    { new Guid("8543eeef-46d4-4716-be26-51f5dab76d6c"), "Dermatology", new Guid("29ac5d41-0fd2-4ee7-b6e9-bad3d7cc7168") },
                    { new Guid("ba2ec211-b7f4-4f83-a83e-edcab8a159f6"), "Cardiac Surgery", new Guid("9051a8c9-6376-4be0-9fcb-e1f82b34d37e") },
                    { new Guid("bb0a0c7a-2176-4897-b658-089de854804c"), "Chiropractic", new Guid("f9ed7116-acfa-4089-9938-14230f1fa1b5") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId", "medicalRecord", "medications", "testResults" },
                values: new object[,]
                {
                    { new Guid("3e55ccea-3d7e-4c1b-889b-d26b9801a01d"), new Guid("6b022c5a-8ed3-478b-8188-7ebf22bbf6ec"), null, null, null },
                    { new Guid("46959aef-4b05-4b46-b4bb-224e404e35d4"), new Guid("49571e2a-5cb8-4824-80a2-98be323b88b7"), null, null, null },
                    { new Guid("4e3cab16-bc26-48fc-b22c-7e19f7f52593"), new Guid("cf54f1f5-246f-4948-8a65-d4cdcbff4f37"), null, null, null },
                    { new Guid("52575b0b-39bd-4cb2-a1cb-03b3b15955ca"), new Guid("5209d3ac-b15a-4cea-ab3d-7c5793f4ee7e"), null, null, null },
                    { new Guid("7a8797a4-cb8f-4e10-87be-1ef1f26dcfac"), new Guid("12b84248-9af0-4e52-b155-16b9ea8d89b5"), null, null, null },
                    { new Guid("7bff02db-9e88-4390-a1a3-799c1bfdcec5"), new Guid("69159b70-cda1-4da1-bb6f-51c91f44e2cd"), null, null, null }
                });
        }
    }
}
