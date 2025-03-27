using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Models.Domain;

namespace planMyMDVisit.Data
{
    public class PlanMyMDVisitContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public PlanMyMDVisitContext(DbContextOptions<PlanMyMDVisitContext> options) : base(options)
        { }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<HealthCareTeam> HealthCareTeams { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var User1Id = Guid.NewGuid();
            var User2Id = Guid.NewGuid();
            var User3Id = Guid.NewGuid();
            var User4Id = Guid.NewGuid();

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = User1Id,
                    FirstName = "Danny",
                    LastName = "Tonner",
                    Email = "dannyt@hotmail.com",
                    UserName = "dannyt"
                });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = User2Id,
                    FirstName = "Vanessa",
                    LastName = "Reagan",
                    Email = "vanessar@hotmail.com",
                    UserName = "vanessar"
                });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = User3Id,
                    FirstName = "Mike",
                    LastName = "Johnson",
                    Email = "mikej@hotmail.com",
                    UserName = "mikej"
                });

            modelBuilder.Entity<User>().HasData(
               new User
               {
                   Id = User4Id,
                   FirstName = "Helen",
                   LastName = "Skyburgh",
                   Email = "helens@hotmail.com",
                   UserName = "helens"
               });





            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Smith",
                    Specialty = "Allergy",
                    UserId = User1Id
                });

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Taylor",
                    Specialty = "Cardiac Surgery",
                    UserId = User2Id
                });

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. White",
                    Specialty = "Chiropractic",
                    UserId = User3Id
                });

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = Guid.NewGuid(),
                    Name = "Dr. Jordan",
                    Specialty = "Dermatology",
                    UserId = User4Id
                });

            modelBuilder.Entity<User>()
                .HasOne(u => u.Doctor)
                .WithOne(d => d.User)
                .HasForeignKey<Doctor>(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Patient)
                .WithOne(d => d.User)
                .HasForeignKey<Patient>(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<HealthCareTeam>()
                .HasOne(u => u.Doctor)
                .WithMany(d => d.HealthCareTeams)
                .HasForeignKey(p => p.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<HealthCareTeam>()
                .HasOne(ht => ht.Patient)
                .WithMany(p => p.HealthCareTeams)
                .HasForeignKey(ht => ht.PatientId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
