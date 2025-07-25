using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace planMyMDVisit.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    DoctorOrPatient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DoctorPatient",
                columns: table => new
                {
                    DoctorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatient", x => new { x.DoctorsId, x.PatientsId });
                    table.ForeignKey(
                        name: "FK_DoctorPatient_Doctors_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorPatient_Patients_PatientsId",
                        column: x => x.PatientsId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthCareTeams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Appointment = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCareTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCareTeams_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCareTeams_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"), null, "admin", "Admin" });

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
                    { new Guid("a0cab2c3-6558-4a1c-be81-dfb39180da3d"), 0, "e54b0c92-30c9-4a20-a907-11e90656a3ac", null, "admin@planMyMD.com", false, null, null, false, null, "ADMIN@PLANMYMD.COM", "ADMIN@PLANMYMD.COM", "AQAAAAIAAYagAAAAEEJB3sxMD1lN+JcPyFE/ACU/J7QKkUCbSUZj5yEOXXvjFCoTyN5vaYDj+/ywFSiZQA==", null, false, null, false, "admin" },
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatient_PatientsId",
                table: "DoctorPatient",
                column: "PatientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareTeams_DoctorId",
                table: "HealthCareTeams",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCareTeams_PatientId",
                table: "HealthCareTeams",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DoctorPatient");

            migrationBuilder.DropTable(
                name: "HealthCareTeams");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
