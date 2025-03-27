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

            //modelBuilder.Entity<Doctor>()
            //    .HasOne(d => d.User)
            //    .WithMany(u => u.HealthCareTeam)
            //    .HasForeignKey(ml => ml.UserId)
            //    .OnDelete(DeleteBehavior.Cascade);

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
