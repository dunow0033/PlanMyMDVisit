using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class puttingsomeseeddatainDoctorstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("744f282f-7620-461c-8f5d-d4e1dbde7c28"), 0, "ef77b738-e921-4065-9da0-1c49fb0bc927", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("bfabd271-4dc2-4045-8c4f-fa0ede925e6f"), 0, "27c5892f-1045-4073-8654-4093f6dc14fe", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" },
                    { new Guid("e21b12a9-a7c4-4641-aa99-186fdf67b09e"), 0, "2e1f5f1c-a405-44cf-b631-c237ab077ade", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("e2704c12-7ef1-4b89-8bcf-78384b1491ac"), 0, "643782fd-fa16-400d-ae9c-831c01abcf75", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Name", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("06bfe529-eeb2-435e-bc60-6194084a9ee6"), "Dr. White", "Chiropractic", new Guid("744f282f-7620-461c-8f5d-d4e1dbde7c28") },
                    { new Guid("6e40b018-1efc-44ca-897e-1f5e28018c64"), "Dr. Taylor", "Cardiac Surgery", new Guid("e21b12a9-a7c4-4641-aa99-186fdf67b09e") },
                    { new Guid("948e454c-793e-4ead-9b98-2f6b137106da"), "Dr. Jordan", "Dermatology", new Guid("e2704c12-7ef1-4b89-8bcf-78384b1491ac") },
                    { new Guid("aee54a64-c77f-406e-ab35-97cde917c8cc"), "Dr. Smith", "Allergy", new Guid("bfabd271-4dc2-4045-8c4f-fa0ede925e6f") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("06bfe529-eeb2-435e-bc60-6194084a9ee6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6e40b018-1efc-44ca-897e-1f5e28018c64"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("948e454c-793e-4ead-9b98-2f6b137106da"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("aee54a64-c77f-406e-ab35-97cde917c8cc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("744f282f-7620-461c-8f5d-d4e1dbde7c28"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bfabd271-4dc2-4045-8c4f-fa0ede925e6f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e21b12a9-a7c4-4641-aa99-186fdf67b09e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e2704c12-7ef1-4b89-8bcf-78384b1491ac"));
        }
    }
}
