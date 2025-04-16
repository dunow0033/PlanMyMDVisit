using Microsoft.EntityFrameworkCore;
using planMyMDVisit.adapters;
using planMyMDVisit.Models.Domain;
using System.Text.Json;

namespace planMyMDVisit.Data
{
    public class DataSeeder
    {
        private readonly PlanMyMDVisitContext context;

        public DataSeeder(PlanMyMDVisitContext context)
        {
            this.context = context;
        }

        public async Task SeedDoctorsAsync()
        {
            //Console.WriteLine("SeedDoctorsAsync started.");

            //if (context.Doctors.Any())
            //{
            //    Console.WriteLine("Doctors already exist in DB. Skipping seeding.");
            //    return;
            //}

            var doctors = await Scraper.GetDoctorsAsync("Any");

            await context.Doctors.AddRangeAsync(doctors);
            await context.SaveChangesAsync();

            // Save to file
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "doctors.json");
            var json = JsonSerializer.Serialize(doctors, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);

            Console.WriteLine($"Doctors.json created at: {filePath}");
        }
    }
}
