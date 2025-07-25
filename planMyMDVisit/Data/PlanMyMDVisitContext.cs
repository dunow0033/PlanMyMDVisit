using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Models.ViewModels;

namespace planMyMDVisit.Data
{
    public class PlanMyMDVisitContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public PlanMyMDVisitContext(DbContextOptions<PlanMyMDVisitContext> options) : base(options)
        { }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<HealthCareTeam> HealthCareTeams { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<IdentityUser> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Users - Patients
            var User1Id = Guid.NewGuid();
            var User2Id = Guid.NewGuid();
            var User3Id = Guid.NewGuid();
            var User4Id = Guid.NewGuid();
            var User5Id = Guid.NewGuid();
            var User6Id = Guid.NewGuid();

            //Users - Doctors
            var User7Id = Guid.NewGuid();
            var User8Id = Guid.NewGuid();
            var User9Id = Guid.NewGuid();
            var User10Id = Guid.NewGuid();
            var User11Id = Guid.NewGuid();
            var User12Id = Guid.NewGuid();
            var User13Id = Guid.NewGuid();

            //patients
            var pId = Guid.NewGuid();
            var pId2 = Guid.NewGuid();
            var pId3 = Guid.NewGuid();
            var pId4 = Guid.NewGuid();
            var pId5 = Guid.NewGuid();
            var pId6 = Guid.NewGuid();
            var pId7 = Guid.NewGuid();
            var pId8 = Guid.NewGuid();
            var pId9 = Guid.NewGuid();
            var pId10 = Guid.NewGuid();

            //doctors
            var dId = Guid.NewGuid();
            var dId2 = Guid.NewGuid();
            var dId3 = Guid.NewGuid();
            var dId4 = Guid.NewGuid();
            var dId5 = Guid.NewGuid();
            var dId6 = Guid.NewGuid();
            var dId7 = Guid.NewGuid();
            var dId8 = Guid.NewGuid();
            var dId9 = Guid.NewGuid();
            var dId10 = Guid.NewGuid();

            //modelBuilder.Entity<Doctor>()
            //    .HasMany(d => d.Patients)
            //    .WithMany(p => p.Doctors)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "DoctorPatient",
            //        j => j.HasOne<Patient>().WithMany().HasForeignKey("PatientsId").OnDelete(DeleteBehavior.NoAction),
            //        j => j.HasOne<Doctor>().WithMany().HasForeignKey("DoctorsId").OnDelete(DeleteBehavior.Cascade)
            //    );

            //modelBuilder.Entity<Doctor>()
            //    .HasMany(d => d.Patients)
            //    .WithMany(p => p.Doctors)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "DoctorPatient", 
            //        j => j
            //            .HasOne<Patient>()
            //            .WithMany()
            //            .HasForeignKey("PatientsId")
            //            .OnDelete(DeleteBehavior.NoAction), 
            //        j => j
            //            .HasOne<Doctor>()
            //            .WithMany()
            //            .HasForeignKey("DoctorsId")
            //            .OnDelete(DeleteBehavior.Cascade) // Only allow cascade delete on one side
            //    );

            modelBuilder.Entity<User>()
                .HasMany(u => u.Patients)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Doctors)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Doctor>()
            //    .HasOne(d => d.User)
            //    .WithMany(u => u.Doctors)
            //    .HasForeignKey<Doctor>(d => d.UserId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Doctor>()
            //    .HasMany(d => d.Patients)
            //    .WithMany(p => p.Doctors)
            //    .UsingEntity(j => j.ToTable("DoctorPatient"));

            modelBuilder.Entity<HealthCareTeam>()
                .HasOne(ht => ht.Doctor)
                .WithMany(d => d.HealthCareTeams)
                .HasForeignKey(ht => ht.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<HealthCareTeam>()
                .HasOne(ht => ht.Patient)
                .WithMany(p => p.HealthCareTeams)
                .HasForeignKey(ht => ht.PatientId)
                .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<User>()
            //    .HasOne(u => u.Patient)
            //    .WithOne(d => d.User)
            //    .HasForeignKey<Patient>(p => p.UserId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<HealthCareTeam>()
            //    .HasOne(ht => ht.Patient)
            //    .WithMany(p => p.HealthCareTeams)
            //    .HasForeignKey(ht => ht.PatientId)
            //    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = pId2, UserId = User1Id },
                new Patient { Id = pId3, UserId = User2Id },
                new Patient { Id = pId4, UserId = User3Id },
                new Patient { Id = pId5, UserId = User4Id },
                new Patient { Id = pId6, UserId = User5Id },
                new Patient { Id = pId7, UserId = User6Id }
             );

            modelBuilder.Entity<User>().HasData(
                new User { Id = User1Id, FirstName = "Danny", DoctorOrPatient = "patient", LastName = "Tonner", Email = "dannyt@hotmail.com", UserName = "dannyt" },
                new User { Id = User2Id, FirstName = "Vanessa", DoctorOrPatient = "patient", LastName = "Reagan", Email = "vanessar@hotmail.com", UserName = "vanessar" },
                new User { Id = User3Id, FirstName = "Mike", DoctorOrPatient = "patient", LastName = "Johnson", Email = "mikej@hotmail.com", UserName = "mikej" },
                new User { Id = User4Id, FirstName = "Helen", DoctorOrPatient = "patient", LastName = "Skyburgh", Email = "helens@hotmail.com", UserName = "helens" },
                new User { Id = User5Id, FirstName = "Brad", DoctorOrPatient = "patient", LastName = "Connors", Email = "bradc@hotmail.com", UserName = "bradc" },
                new User { Id = User6Id, FirstName = "Rick", DoctorOrPatient = "patient", LastName = "Nyburgh", Email = "rickn@hotmail.com", UserName = "rickn" },
                new User { Id = User7Id, FirstName = "Dan", DoctorOrPatient = "patient", LastName = "Riley", Email = "danr@hotmail.com", UserName = "danr" },
                new User { Id = User8Id, FirstName = "Patrick", DoctorOrPatient = "doctor", LastName = "Hordner", Email = "path@hotmail.com", UserName = "path" },
                new User { Id = User9Id, FirstName = "Timmy", DoctorOrPatient = "doctor", LastName = "Rudner", Email = "timr@hotmail.com", UserName = "timr" },
                new User { Id = User10Id, FirstName = "Jack", DoctorOrPatient = "doctor", LastName = "Sackson", Email = "jacks@hotmail.com", UserName = "jacks" },
                new User { Id = User11Id, FirstName = "Sammy", DoctorOrPatient = "doctor", LastName = "Rostun", Email = "samr@hotmail.com", UserName = "samr" },
                new User { Id = User12Id, FirstName = "Nicholas", DoctorOrPatient = "doctor", LastName = "Perkins", Email = "nickp@hotmail.com", UserName = "nickp" }
             );

            //modelBuilder.Entity<Patient>().HasData(
            //    new Patient { Id = User1Id, FirstName = "Danny", LastName = "Tonner" },
            //    new Patient {Id = User2Id, FirstName = "Vanessa", LastName = "Reagan" },
            //    new Patient {Id = User3Id, FirstName = "Mike", LastName = "Johnson" },
            //    new Patient {Id = User4Id, FirstName = "Helen", LastName = "Skyburgh" },
            //    new Patient {Id = User5Id, FirstName = "Brad", LastName = "Connors" },
            //    new Patient {Id = User6Id, FirstName = "Rick", LastName = "Nyburgh" }
            // );

            //modelBuilder.Entity<User>().HasData(
            //    new User { Id = User1Id, FirstName = "Danny", LastName = "Tonner", Email = "dannyt@hotmail.com", UserName = "dannyt" },
            //    new User { Id = User2Id, FirstName = "Vanessa", LastName = "Reagan", Email = "vanessar@hotmail.com", UserName = "vanessar" },
            //    new User { Id = User3Id, FirstName = "Mike", LastName = "Johnson", Email = "mikej@hotmail.com", UserName = "mikej" },
            //    new User { Id = User4Id, FirstName = "Helen", LastName = "Skyburgh", Email = "helens@hotmail.com", UserName = "helens" },
            //    new User { Id = User5Id, FirstName = "Brad", LastName = "Connors", Email = "bradc@hotmail.com", UserName = "bradc" },
            //    new User { Id = User6Id, FirstName = "Rick", LastName = "Nyburgh", Email = "rickn@hotmail.com", UserName = "rickn" }
            //);


            //modelBuilder.Entity<Doctor>().HasData(
            //    new Doctor { Id = Guid.NewGuid(), Name = "Dr. Smith", Specialty = "Allergy", UserId = User1Id },
            //    new Doctor { Id = Guid.NewGuid(), Name = "Dr. Taylor", Specialty = "Cardiac Surgery", UserId = User2Id },
            //    new Doctor { Id = Guid.NewGuid(), Name = "Dr. Rogers", Specialty = "Dermatology", UserId = User2Id },
            //    new Doctor { Id = Guid.NewGuid(), Name = "Dr. Banks", Specialty = "Dermatology", UserId = User2Id },
            //    new Doctor { Id = Guid.NewGuid(), Name = "Dr. White", Specialty = "Chiropractic", UserId = User2Id },
            //    new Doctor { Id = Guid.NewGuid(), Name = "Dr. Jordan", Specialty = "Dermatology", UserId = User2Id }
            // );

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = dId, UserId = User7Id, Specialty = "Allergy" },
                new Doctor { Id = dId2, UserId = User8Id, Specialty = "Cardiac Surgery" },
                new Doctor { Id = dId3, UserId = User9Id, Specialty = "Dermatology" },
                new Doctor { Id = dId4, UserId = User10Id, Specialty = "Dermatology" },
                new Doctor { Id = dId5, UserId = User11Id, Specialty = "Chiropractic" },
                new Doctor { Id = dId6, UserId = User12Id, Specialty = "Dermatology" }
             );

            //Seed Roles
            
            var adminId = Guid.Parse("a0cab2c3-6558-4a1c-be81-dfb39180da3d");

            modelBuilder.Entity<IdentityRole<Guid>>().HasData(
            
                new IdentityRole<Guid>
                {
                    Id = adminId,
                    Name = "admin",
                    NormalizedName = "Admin",    
                }
            );

            var admin = new User
            {
                Id = adminId,
                UserName = "admin",
                Email = "admin@planMyMD.com",
                DoctorOrPatient = "admin",
                NormalizedEmail = "admin@planMyMD.com".ToUpper(),
                NormalizedUserName = "admin".ToUpper(),
                SecurityStamp = Guid.NewGuid().ToString()
            };

            admin.PasswordHash = new PasswordHasher<User>().HashPassword(admin, "admin");

            modelBuilder.Entity<User>().HasData(admin);

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    UserId = Guid.Parse("A0CAB2C3-6558-4A1C-BE81-DFB39180DA3D"),  // admin user ID
                    RoleId = Guid.Parse("A0CAB2C3-6558-4A1C-BE81-DFB39180DA3D")
                });
        }
    }
}
