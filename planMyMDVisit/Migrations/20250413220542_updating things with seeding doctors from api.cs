using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class updatingthingswithseedingdoctorsfromapi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c6ebea0c-be35-400f-8eac-fd533773f5a7"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("93a6a6ed-7e07-4943-9eba-4df0c069dba4"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a2942e88-ae51-4f53-91e2-7cd42d2886df"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b0ae4fcd-df25-44eb-98ac-11437d1e153a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b7fc159e-b20e-478c-94b4-adfeab42ef3a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d4ab11bf-223d-417c-9946-75a5e892cebe"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("df928327-1e93-49b9-b49c-5c5c3bfd36f7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("236ec25e-f666-4663-a30f-b17216fb8386"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d026771e-63bc-4b7f-9d60-b75402f4a6a8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("dad64934-beea-4c73-bb32-13fca27d6f24"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6b47b7f4-ba62-4625-9993-9cdecbf57d2f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8c596cf9-9ee7-4770-b22c-a52569177a00"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("acdd0657-7cf1-4121-bb21-0a49edda3312"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f4198380-d6b1-4d88-b397-b970e6ccee67"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("6b47b7f4-ba62-4625-9993-9cdecbf57d2f"), 0, "2d6e3986-2a87-464f-a380-3611b3b28eb3", "bradc@hotmail.com", false, "Brad", "Connors", false, null, null, null, null, null, false, null, false, "bradc" },
                    { new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), 0, "4026741b-3c58-4f7d-ab2d-52dc98d615b9", "vanessar@hotmail.com", false, "Vanessa", "Reagan", false, null, null, null, null, null, false, null, false, "vanessar" },
                    { new Guid("8c596cf9-9ee7-4770-b22c-a52569177a00"), 0, "3df3d42b-a9b1-4357-a044-a3d3fc75d3e3", "helens@hotmail.com", false, "Helen", "Skyburgh", false, null, null, null, null, null, false, null, false, "helens" },
                    { new Guid("acdd0657-7cf1-4121-bb21-0a49edda3312"), 0, "dc60aa8f-ed7f-477b-8d89-d68a2b410a6a", "rickn@hotmail.com", false, "Rick", "Nyburgh", false, null, null, null, null, null, false, null, false, "rickn" },
                    { new Guid("c6ebea0c-be35-400f-8eac-fd533773f5a7"), 0, "fa396aeb-e3a9-400a-ad34-faac74fe9abb", "mikej@hotmail.com", false, "Mike", "Johnson", false, null, null, null, null, null, false, null, false, "mikej" },
                    { new Guid("f4198380-d6b1-4d88-b397-b970e6ccee67"), 0, "66df36f2-c3a2-4dd9-937a-ef678ead0b3a", "dannyt@hotmail.com", false, "Danny", "Tonner", false, null, null, null, null, null, false, null, false, "dannyt" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "City", "Gender", "Hospital", "Name", "Specialty", "State", "UserId", "Zipcode" },
                values: new object[,]
                {
                    { new Guid("93a6a6ed-7e07-4943-9eba-4df0c069dba4"), null, null, null, null, "Dr. Taylor", "Cardiac Surgery", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null },
                    { new Guid("a2942e88-ae51-4f53-91e2-7cd42d2886df"), null, null, null, null, "Dr. Rogers", "Dermatology", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null },
                    { new Guid("b0ae4fcd-df25-44eb-98ac-11437d1e153a"), null, null, null, null, "Dr. Smith", "Allergy", null, new Guid("f4198380-d6b1-4d88-b397-b970e6ccee67"), null },
                    { new Guid("b7fc159e-b20e-478c-94b4-adfeab42ef3a"), null, null, null, null, "Dr. Banks", "Dermatology", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null },
                    { new Guid("d4ab11bf-223d-417c-9946-75a5e892cebe"), null, null, null, null, "Dr. White", "Chiropractic", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null },
                    { new Guid("df928327-1e93-49b9-b49c-5c5c3bfd36f7"), null, null, null, null, "Dr. Jordan", "Dermatology", null, new Guid("8b110268-8a34-4783-b9b9-036b8aba2a31"), null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { new Guid("236ec25e-f666-4663-a30f-b17216fb8386"), new Guid("6b47b7f4-ba62-4625-9993-9cdecbf57d2f") },
                    { new Guid("d026771e-63bc-4b7f-9d60-b75402f4a6a8"), new Guid("8c596cf9-9ee7-4770-b22c-a52569177a00") },
                    { new Guid("dad64934-beea-4c73-bb32-13fca27d6f24"), new Guid("acdd0657-7cf1-4121-bb21-0a49edda3312") }
                });
        }
    }
}
