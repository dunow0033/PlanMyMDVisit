using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class correctingtheissuewiththeSpecialtyvariableinHealthCareTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "HealthCareTeams",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("013d94df-29f7-4634-bfaf-81245d58192a"), 0, "563f7092-87bb-45ed-bd03-fd49011a6e61", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("0776dfbb-5255-40cf-8b25-c61532fa6ce8"), 0, "f19e35ba-9c0e-45da-a141-971a40eeb013", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("16df2b94-3b05-4f00-998f-1c33719a8d73"), 0, "cc331464-e884-4e95-9c01-a6f51383d2e6", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("441a14de-2c74-41b7-8ab5-edd5ce3dd9d6"), 0, "4664e469-3eb5-4499-83be-480006063149", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("ce4b993b-8d0a-47f5-bd11-24983e4fcfd2"), 0, "c65f1e1c-4b19-4bbc-8062-410f46e8a98a", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("d0337856-ffe2-4fee-9bed-13b992dd2046"), 0, "9f748eee-0b59-4423-b1ca-9f60b3e95616", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("2189f5e1-5e5e-4531-bb14-5fa268226855"), "Dr. Jordan", "Dermatology", new Guid("ce4b993b-8d0a-47f5-bd11-24983e4fcfd2") },
                    { new Guid("46f2bc6a-d3c3-4e0a-a0e9-b421dbabd330"), "Dr. Smith", "Allergy", new Guid("0776dfbb-5255-40cf-8b25-c61532fa6ce8") },
                    { new Guid("4f79d3ab-9157-4402-8efc-af7b1105b185"), "Dr. White", "Chiropractic", new Guid("ce4b993b-8d0a-47f5-bd11-24983e4fcfd2") },
                    { new Guid("710a5536-a5ac-483a-a468-6bae5ea0bc3d"), "Dr. Banks", "Dermatology", new Guid("ce4b993b-8d0a-47f5-bd11-24983e4fcfd2") },
                    { new Guid("a909439c-9b4f-4b38-8afe-5d34c9565875"), "Dr. Taylor", "Cardiac Surgery", new Guid("ce4b993b-8d0a-47f5-bd11-24983e4fcfd2") },
                    { new Guid("db25095e-ce36-4d31-a3f1-0782c00718c2"), "Dr. Rogers", "Dermatology", new Guid("ce4b993b-8d0a-47f5-bd11-24983e4fcfd2") }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("0d61cfe1-ebbc-4194-9ad7-4f241864663d"), new Guid("16df2b94-3b05-4f00-998f-1c33719a8d73") },
                    { new Guid("2cec381c-39eb-43b5-be42-d2c9eaca1884"), new Guid("013d94df-29f7-4634-bfaf-81245d58192a") },
                    { new Guid("39f844ef-6797-4171-91ad-8b74b6392d3b"), new Guid("d0337856-ffe2-4fee-9bed-13b992dd2046") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("441a14de-2c74-41b7-8ab5-edd5ce3dd9d6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2189f5e1-5e5e-4531-bb14-5fa268226855"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("46f2bc6a-d3c3-4e0a-a0e9-b421dbabd330"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4f79d3ab-9157-4402-8efc-af7b1105b185"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("710a5536-a5ac-483a-a468-6bae5ea0bc3d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a909439c-9b4f-4b38-8afe-5d34c9565875"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("db25095e-ce36-4d31-a3f1-0782c00718c2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("0d61cfe1-ebbc-4194-9ad7-4f241864663d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2cec381c-39eb-43b5-be42-d2c9eaca1884"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("39f844ef-6797-4171-91ad-8b74b6392d3b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("013d94df-29f7-4634-bfaf-81245d58192a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0776dfbb-5255-40cf-8b25-c61532fa6ce8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("16df2b94-3b05-4f00-998f-1c33719a8d73"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce4b993b-8d0a-47f5-bd11-24983e4fcfd2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d0337856-ffe2-4fee-9bed-13b992dd2046"));

            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "HealthCareTeams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
