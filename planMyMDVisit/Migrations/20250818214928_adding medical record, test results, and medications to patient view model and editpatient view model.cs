using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class addingmedicalrecordtestresultsandmedicationstopatientviewmodelandeditpatientviewmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("00f77c5c-f394-44a4-b5d9-69da9cd0b6a5"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2d6e2112-d7b2-419e-aaf2-91bbcadba09d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("49127570-281d-4959-bf57-31288572add0"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8cca4874-f01b-4dc4-a1b7-9ab932aa40f9"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cf8aee50-f439-4998-b927-7e4081f0b3e9"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d1ea3ffa-d9c5-451a-a2ac-665be41c78e4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("16f012c6-e872-4708-9cb0-78ac0303c42d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3b1ae60c-90a5-4537-9a6d-05cce94e93e0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("5288d485-6dcc-4cec-bd33-66dec6e26969"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("9061f8b7-2058-4f3e-a63a-b2556cc09a70"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d4f227bf-91c9-44da-a5d6-607f0265f2fe"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d85c77d8-a0f4-4618-86f9-7fc5a75b112f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("14fd7d49-9ae5-482e-98c5-90fce3a11f56"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23620d04-c9f7-4cac-bde7-8cb7f501c610"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("24d11053-b0cf-4885-89ea-34219538e41e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30aac335-a2f2-40c5-85d0-57d45e37f6aa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ada84c1-13b7-40da-abdc-d79f1cebfe22"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b3123369-3fc5-4cb1-ba3f-f0f7e1da6c35"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bb5e57af-d934-4348-a871-8a8a2ba7279c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4342e2f-6428-4c12-bb0b-69369f2155ab"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d745e220-2233-4e86-96b4-357b105d9274"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("db862a03-f901-4e1c-b847-82c68164d39d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e6d9f6a5-3184-42f5-865b-2e0d50c90e06"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed2713b4-dd81-46b5-ae90-544a3785b112"));

            migrationBuilder.AddColumn<string>(
                name: "medicalRecord",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "medications",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "testResults",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "medicalRecord",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "medications",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "testResults",
                table: "Patients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e9c3bee-a661-4c0b-91cb-67facb26b375", "AQAAAAIAAYagAAAAELIdDoThpdaS6DhfVbBAXFjmIm9tfp3FBQ2czcXmUJ7IjAH7wGQVfn2b0WhbxLm4nw==", "c3ef7eb6-9e1f-4c38-997c-f7c407753455" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Admin", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("14fd7d49-9ae5-482e-98c5-90fce3a11f56"), 0, false, "8c538a0b-f5a7-4293-8fdc-dfba7679bc9f", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" },
                    { new Guid("23620d04-c9f7-4cac-bde7-8cb7f501c610"), 0, false, "6573e696-ce0f-43ec-b559-93a363e73753", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("24d11053-b0cf-4885-89ea-34219538e41e"), 0, false, "d3d2c1ef-23a4-4760-8342-65fd553b052e", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("30aac335-a2f2-40c5-85d0-57d45e37f6aa"), 0, false, "76b38aaa-f187-4b6e-a893-82155ffbe0b8", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("9ada84c1-13b7-40da-abdc-d79f1cebfe22"), 0, false, "01195b5b-d29d-43bb-b935-7a415b12e1d3", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("b3123369-3fc5-4cb1-ba3f-f0f7e1da6c35"), 0, false, "b588826f-fd68-447a-9bb0-59c05af32ca8", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("bb5e57af-d934-4348-a871-8a8a2ba7279c"), 0, false, "711f3fea-5fd8-4e96-83ed-252978244ffd", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" },
                    { new Guid("d4342e2f-6428-4c12-bb0b-69369f2155ab"), 0, false, "6250ab14-edfe-49f5-8cbf-263821bd8213", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" },
                    { new Guid("d745e220-2233-4e86-96b4-357b105d9274"), 0, false, "2d3241f5-2e91-4e4e-a414-c9717c0bf6d8", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" },
                    { new Guid("db862a03-f901-4e1c-b847-82c68164d39d"), 0, false, "ae389284-2127-4e2c-9b22-ee6454d4a1ca", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("e6d9f6a5-3184-42f5-865b-2e0d50c90e06"), 0, false, "6c391882-26a3-4bb0-b45a-7ff4923a6f25", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("ed2713b4-dd81-46b5-ae90-544a3785b112"), 0, false, "5c386e1c-a60c-40f0-80db-6e52a850b677", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("00f77c5c-f394-44a4-b5d9-69da9cd0b6a5"), "Dermatology", new Guid("d4342e2f-6428-4c12-bb0b-69369f2155ab") },
                    { new Guid("2d6e2112-d7b2-419e-aaf2-91bbcadba09d"), "Allergy", new Guid("14fd7d49-9ae5-482e-98c5-90fce3a11f56") },
                    { new Guid("49127570-281d-4959-bf57-31288572add0"), "Dermatology", new Guid("bb5e57af-d934-4348-a871-8a8a2ba7279c") },
                    { new Guid("8cca4874-f01b-4dc4-a1b7-9ab932aa40f9"), "Dermatology", new Guid("24d11053-b0cf-4885-89ea-34219538e41e") },
                    { new Guid("cf8aee50-f439-4998-b927-7e4081f0b3e9"), "Cardiac Surgery", new Guid("db862a03-f901-4e1c-b847-82c68164d39d") },
                    { new Guid("d1ea3ffa-d9c5-451a-a2ac-665be41c78e4"), "Chiropractic", new Guid("d745e220-2233-4e86-96b4-357b105d9274") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("16f012c6-e872-4708-9cb0-78ac0303c42d"), new Guid("30aac335-a2f2-40c5-85d0-57d45e37f6aa") },
                    { new Guid("3b1ae60c-90a5-4537-9a6d-05cce94e93e0"), new Guid("e6d9f6a5-3184-42f5-865b-2e0d50c90e06") },
                    { new Guid("5288d485-6dcc-4cec-bd33-66dec6e26969"), new Guid("23620d04-c9f7-4cac-bde7-8cb7f501c610") },
                    { new Guid("9061f8b7-2058-4f3e-a63a-b2556cc09a70"), new Guid("9ada84c1-13b7-40da-abdc-d79f1cebfe22") },
                    { new Guid("d4f227bf-91c9-44da-a5d6-607f0265f2fe"), new Guid("b3123369-3fc5-4cb1-ba3f-f0f7e1da6c35") },
                    { new Guid("d85c77d8-a0f4-4618-86f9-7fc5a75b112f"), new Guid("ed2713b4-dd81-46b5-ae90-544a3785b112") }
                });
        }
    }
}
