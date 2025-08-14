using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class addingAdminpropertytotheUsermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("67d4f75a-d037-41ac-8352-e0c24e608351"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7c3b4d79-63e0-4129-af7e-87900753aabb"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8e4c588b-6d7f-454b-aece-30a404c2f224"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9cad0deb-bb69-4252-9032-a0c2efde1128"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("afd7c169-ea6f-43ca-b4f3-544e21f231b2"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cd312da6-dbd5-4b14-aad6-a5342af2c1d2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("09ba6828-2823-43a1-abb5-760ab6353000"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2af6e876-6d39-4cfb-9f41-3abb85531d8c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("33c261df-fea7-4f99-836a-178d3db9e781"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("55e49e3a-1d54-4bef-a2ad-d8fc288f1bed"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("8495bf28-def9-4856-ab4f-94e33f7b794f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d335511a-776c-4cb3-bbaf-d80daff466f7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("25e98b4a-bc30-4ebf-a6a8-ec65f1bac448"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2b0acab4-2c27-435b-98e4-769389ba7d4a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34ece4f0-e8b2-4d0e-952b-1c7c7f8be186"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4286ed8c-5415-4f8d-8567-970255e9c5e6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("60402d90-6abc-4da9-b20b-370c7df6876e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("655d0f9a-eae6-4261-be9f-e4130896b60a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("67ba71de-fb9b-4196-b0c2-37affeab44ac"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("71a39b44-5b32-4302-9725-fb9999b19991"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9952df63-4c05-4b03-a1e2-5dc85dd1e4b0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aff6367d-37c5-4eb3-862b-2141fa51f87b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f482edc9-de66-4268-ad44-71289b8b4eb8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fef64eab-8353-460e-ac94-bcc5d163e1d0"));

            migrationBuilder.AddColumn<bool>(
                name: "Admin",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "Admin", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { false, "3e9c3bee-a661-4c0b-91cb-67facb26b375", "AQAAAAIAAYagAAAAELIdDoThpdaS6DhfVbBAXFjmIm9tfp3FBQ2czcXmUJ7IjAH7wGQVfn2b0WhbxLm4nw==", "c3ef7eb6-9e1f-4c38-997c-f7c407753455" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Admin",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7ddc449-7e25-4fb6-92aa-22dedd46b57b", "AQAAAAIAAYagAAAAEAkqhomgyCwvbsDQoRLlxSwFlDtA8DJjnNmiynWMdhX1XApmnY+7pATvHO2tJtlyGw==", "289ca17c-e1bb-4597-9974-599d445d6b61" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoctorOrPatient", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("25e98b4a-bc30-4ebf-a6a8-ec65f1bac448"), 0, "f3f93d4f-c5fd-4f45-be39-28492033ca39", "patient", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("2b0acab4-2c27-435b-98e4-769389ba7d4a"), 0, "04283e59-b543-4d40-8ab0-1bd05f50e061", "patient", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("34ece4f0-e8b2-4d0e-952b-1c7c7f8be186"), 0, "084a0802-a95e-4d8b-b813-6f3d203a7f01", "patient", "danr@hotmail.com", false, "Dan", "Riley", false, null, null, null, null, null, false, null, false, "danr" },
                    { new Guid("4286ed8c-5415-4f8d-8567-970255e9c5e6"), 0, "40df5904-c061-4594-addd-86914e0820ad", "doctor", "nickp@hotmail.com", false, "Nicholas", "Perkins", false, null, null, null, null, null, false, null, false, "nickp" },
                    { new Guid("60402d90-6abc-4da9-b20b-370c7df6876e"), 0, "3c6512c6-4e21-4dde-8777-2803fa947728", "doctor", "jacks@hotmail.com", false, "Jack", "Sackson", false, null, null, null, null, null, false, null, false, "jacks" },
                    { new Guid("655d0f9a-eae6-4261-be9f-e4130896b60a"), 0, "c30d982e-927c-413b-97c6-f4702fdd92ac", "patient", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("67ba71de-fb9b-4196-b0c2-37affeab44ac"), 0, "835f64c3-86bc-48c8-8643-8fe19335f178", "patient", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("71a39b44-5b32-4302-9725-fb9999b19991"), 0, "6ae3e0e9-a21f-46d5-a25d-91cd8d398ddc", "doctor", "timr@hotmail.com", false, "Timmy", "Rudner", false, null, null, null, null, null, false, null, false, "timr" },
                    { new Guid("9952df63-4c05-4b03-a1e2-5dc85dd1e4b0"), 0, "59fac548-a0d5-4051-93ec-b47bfdaeb3e9", "doctor", "path@hotmail.com", false, "Patrick", "Hordner", false, null, null, null, null, null, false, null, false, "path" },
                    { new Guid("aff6367d-37c5-4eb3-862b-2141fa51f87b"), 0, "3fc27e7d-a4d7-4fe0-8e5d-44a4ab6feb9f", "patient", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("f482edc9-de66-4268-ad44-71289b8b4eb8"), 0, "959f401a-e67a-4b4e-b84a-2ed0508a527c", "patient", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("fef64eab-8353-460e-ac94-bcc5d163e1d0"), 0, "f2d476b5-e3bb-4230-a4ca-89ed1692a5fe", "doctor", "samr@hotmail.com", false, "Sammy", "Rostun", false, null, null, null, null, null, false, null, false, "samr" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("67d4f75a-d037-41ac-8352-e0c24e608351"), "Allergy", new Guid("34ece4f0-e8b2-4d0e-952b-1c7c7f8be186") },
                    { new Guid("7c3b4d79-63e0-4129-af7e-87900753aabb"), "Dermatology", new Guid("60402d90-6abc-4da9-b20b-370c7df6876e") },
                    { new Guid("8e4c588b-6d7f-454b-aece-30a404c2f224"), "Dermatology", new Guid("71a39b44-5b32-4302-9725-fb9999b19991") },
                    { new Guid("9cad0deb-bb69-4252-9032-a0c2efde1128"), "Dermatology", new Guid("4286ed8c-5415-4f8d-8567-970255e9c5e6") },
                    { new Guid("afd7c169-ea6f-43ca-b4f3-544e21f231b2"), "Chiropractic", new Guid("fef64eab-8353-460e-ac94-bcc5d163e1d0") },
                    { new Guid("cd312da6-dbd5-4b14-aad6-a5342af2c1d2"), "Cardiac Surgery", new Guid("9952df63-4c05-4b03-a1e2-5dc85dd1e4b0") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("09ba6828-2823-43a1-abb5-760ab6353000"), new Guid("67ba71de-fb9b-4196-b0c2-37affeab44ac") },
                    { new Guid("2af6e876-6d39-4cfb-9f41-3abb85531d8c"), new Guid("2b0acab4-2c27-435b-98e4-769389ba7d4a") },
                    { new Guid("33c261df-fea7-4f99-836a-178d3db9e781"), new Guid("655d0f9a-eae6-4261-be9f-e4130896b60a") },
                    { new Guid("55e49e3a-1d54-4bef-a2ad-d8fc288f1bed"), new Guid("aff6367d-37c5-4eb3-862b-2141fa51f87b") },
                    { new Guid("8495bf28-def9-4856-ab4f-94e33f7b794f"), new Guid("f482edc9-de66-4268-ad44-71289b8b4eb8") },
                    { new Guid("d335511a-776c-4cb3-bbaf-d80daff466f7"), new Guid("25e98b4a-bc30-4ebf-a6a8-ec65f1bac448") }
                });
        }
    }
}
