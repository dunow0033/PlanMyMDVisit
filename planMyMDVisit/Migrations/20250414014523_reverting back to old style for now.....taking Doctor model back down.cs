using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class revertingbacktooldstylefornowtakingDoctormodelbackdown : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8cf5b37f-ce94-4378-b24f-94b0c3f04abf"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2e7133af-ece6-417e-b26b-bc3040e60560"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6e53efbb-c955-4ff8-839a-9500db69f30b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c2574295-95d1-4349-aff3-e6af78e82eae"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e6227502-0459-473e-ad8f-cc3b2b3f7118"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e95efa6a-6dc1-4a74-8d9f-be14b9a3681f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f0d0d535-f4de-4ff8-a956-5318a25a454c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1650c8db-24ed-4ed3-acb0-d00a367c74d4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("513f5bd1-c5aa-4e30-a91f-bf6f1d394291"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e78b7c40-1fa4-445d-933b-346d5af1c038"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("586e47d1-b08a-4ad8-b96c-46b5abc533ae"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("596bafc0-fa8e-4c53-8679-73677cb7ea2c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6c9d7f9e-2e6f-4dae-854e-cabb881e2135"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c50d749e-927e-471a-bf33-efe1be00adf1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7a3324d-e1bc-46ab-aa96-d9d3f6d73571"));

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Hospital",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Zipcode",
                table: "Doctors");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0d7c569a-54f0-4517-8aa7-99d1a4065b14"), 0, "38be6b28-030b-44b4-b728-0b51012eb2ac", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("2393e573-b1e9-4693-be21-04030c94130c"), 0, "8b3bce3f-055f-4af7-94b5-995586a5635f", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("274b05f1-589d-4290-8440-dc1dcc83bcfa"), 0, "0775c719-84f2-4dc9-84d6-368b5f2fb322", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("621f5d5e-dd51-42a2-8d21-bf31e8291e1c"), 0, "97eb76fa-3ca2-4272-a125-1a61dbb7f020", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("95d7158b-7c21-4d9d-9260-8eb06e6f0543"), 0, "0878240d-b358-4def-b1bb-221dbc747f8c", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("b84e9f13-fbfe-4dc9-a15d-8ffdcf2b3417"), 0, "f3d7480f-e8bd-4f1d-b414-5aadfbe6b220", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("101f9ede-bc29-45e8-96ad-1eba31fb037c"), "Dr. Jordan", "Dermatology", new Guid("0d7c569a-54f0-4517-8aa7-99d1a4065b14") },
                    { new Guid("501fd134-4760-45d8-9333-a8dc8af79e8c"), "Dr. Taylor", "Cardiac Surgery", new Guid("0d7c569a-54f0-4517-8aa7-99d1a4065b14") },
                    { new Guid("54ffb899-2156-4470-b166-5ce8e86b509f"), "Dr. Banks", "Dermatology", new Guid("0d7c569a-54f0-4517-8aa7-99d1a4065b14") },
                    { new Guid("cfc5cfe6-e47f-46aa-b959-6470f4ee8370"), "Dr. White", "Chiropractic", new Guid("0d7c569a-54f0-4517-8aa7-99d1a4065b14") },
                    { new Guid("d077a09d-0f67-4cda-a036-abd5d6442806"), "Dr. Rogers", "Dermatology", new Guid("0d7c569a-54f0-4517-8aa7-99d1a4065b14") },
                    { new Guid("e6b6c16d-7859-4c1b-bec4-c386d580d7bd"), "Dr. Smith", "Allergy", new Guid("95d7158b-7c21-4d9d-9260-8eb06e6f0543") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("1757e6d1-dbea-4cb7-80cc-b9add69ae830"), new Guid("274b05f1-589d-4290-8440-dc1dcc83bcfa") },
                    { new Guid("18cf61cc-ee75-402b-ad02-22b8072c15e6"), new Guid("2393e573-b1e9-4693-be21-04030c94130c") },
                    { new Guid("1f1edcbe-2c43-4ec8-9927-52529e8fc728"), new Guid("621f5d5e-dd51-42a2-8d21-bf31e8291e1c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b84e9f13-fbfe-4dc9-a15d-8ffdcf2b3417"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("101f9ede-bc29-45e8-96ad-1eba31fb037c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("501fd134-4760-45d8-9333-a8dc8af79e8c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("54ffb899-2156-4470-b166-5ce8e86b509f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cfc5cfe6-e47f-46aa-b959-6470f4ee8370"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d077a09d-0f67-4cda-a036-abd5d6442806"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e6b6c16d-7859-4c1b-bec4-c386d580d7bd"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1757e6d1-dbea-4cb7-80cc-b9add69ae830"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("18cf61cc-ee75-402b-ad02-22b8072c15e6"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1f1edcbe-2c43-4ec8-9927-52529e8fc728"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0d7c569a-54f0-4517-8aa7-99d1a4065b14"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2393e573-b1e9-4693-be21-04030c94130c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("274b05f1-589d-4290-8440-dc1dcc83bcfa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("621f5d5e-dd51-42a2-8d21-bf31e8291e1c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("95d7158b-7c21-4d9d-9260-8eb06e6f0543"));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hospital",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zipcode",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("586e47d1-b08a-4ad8-b96c-46b5abc533ae"), 0, "eb9254d1-c77a-40e4-b17c-cdbef3c188e3", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("596bafc0-fa8e-4c53-8679-73677cb7ea2c"), 0, "45df996f-2f91-47e4-8bae-e23185f9deec", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("6c9d7f9e-2e6f-4dae-854e-cabb881e2135"), 0, "8242d90b-7089-4e25-9654-d4eb0e7273cf", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("8cf5b37f-ce94-4378-b24f-94b0c3f04abf"), 0, "9774e580-be3b-41f4-9320-3e589559c60b", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("c50d749e-927e-471a-bf33-efe1be00adf1"), 0, "3e9afdaa-f0b8-4f7d-85e2-51cc185a14a8", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("e7a3324d-e1bc-46ab-aa96-d9d3f6d73571"), 0, "c424498c-51c1-43ac-8cb4-e3d134394a7e", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "City", "Gender", "Hospital", "Name", "Specialty", "State", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("2e7133af-ece6-417e-b26b-bc3040e60560"), null, null, null, null, "Dr. Smith", "Allergy", null, new Guid("586e47d1-b08a-4ad8-b96c-46b5abc533ae"), null },
                    { new Guid("6e53efbb-c955-4ff8-839a-9500db69f30b"), null, null, null, null, "Dr. Banks", "Dermatology", null, new Guid("c50d749e-927e-471a-bf33-efe1be00adf1"), null },
                    { new Guid("c2574295-95d1-4349-aff3-e6af78e82eae"), null, null, null, null, "Dr. White", "Chiropractic", null, new Guid("c50d749e-927e-471a-bf33-efe1be00adf1"), null },
                    { new Guid("e6227502-0459-473e-ad8f-cc3b2b3f7118"), null, null, null, null, "Dr. Rogers", "Dermatology", null, new Guid("c50d749e-927e-471a-bf33-efe1be00adf1"), null },
                    { new Guid("e95efa6a-6dc1-4a74-8d9f-be14b9a3681f"), null, null, null, null, "Dr. Taylor", "Cardiac Surgery", null, new Guid("c50d749e-927e-471a-bf33-efe1be00adf1"), null },
                    { new Guid("f0d0d535-f4de-4ff8-a956-5318a25a454c"), null, null, null, null, "Dr. Jordan", "Dermatology", null, new Guid("c50d749e-927e-471a-bf33-efe1be00adf1"), null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("1650c8db-24ed-4ed3-acb0-d00a367c74d4"), new Guid("e7a3324d-e1bc-46ab-aa96-d9d3f6d73571") },
                    { new Guid("513f5bd1-c5aa-4e30-a91f-bf6f1d394291"), new Guid("6c9d7f9e-2e6f-4dae-854e-cabb881e2135") },
                    { new Guid("e78b7c40-1fa4-445d-933b-346d5af1c038"), new Guid("596bafc0-fa8e-4c53-8679-73677cb7ea2c") }
                });
        }
    }
}
