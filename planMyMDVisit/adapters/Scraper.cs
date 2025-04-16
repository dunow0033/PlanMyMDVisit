using planMyMDVisit.Models.Domain;
using System;
using System.Text.Json;
using static System.Globalization.CultureInfo;

namespace planMyMDVisit.adapters
{
    public class Scraper
    {
        private static Uri uri;
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task<List<Doctor>> GetDoctorsAsync(string name)
        {
            string url = "https://data.cms.gov/provider-data/api/1/datastore/sql?query=%5BSELECT%20%2A%20FROM%20de1ecf9c-1c24-51fd-873b-15626d329f5a%5D%3B";

            HttpResponseMessage response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            if(!response.IsSuccessStatusCode)
            {
                string errorDetails = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Request failed: {(int)response.StatusCode} {response.ReasonPhrase}");
                Console.WriteLine($"Response content: {errorDetails}");
                return new List<Doctor>();
            }

            string jsonString = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(jsonString);
            var data = doc.RootElement.GetProperty("data");

            var doctors = new List<Doctor>();

            foreach (var row in data.EnumerateArray())
            {
                if (row.ValueKind != JsonValueKind.Array || row.GetArrayLength() == 0)
                    continue;

                try
                {
                    var firstname = Capitalize(row[9].GetString());
                    var lastname = Capitalize(row[8].GetString());
                    var username = (firstname[0] + lastname.Split(' ')[^1].ToLower());
                    var email = username + "@me.com";
                    var password = username;

                    var user = new User
                    {
                        Id = Guid.NewGuid(),
                        FirstName = firstname,
                        LastName = lastname,
                        Email = email,
                        PasswordHash = password,
                    };

                    //doctors.Add(new Doctor
                    //{
                    //    Gender = row[10].GetString(),
                    //    Specialty = Capitalize(row[11].GetString()),
                    //    Hospital = string.IsNullOrWhiteSpace(row[14].GetString()) ? "Kaiser Permanente" : Capitalize(row[14].GetString()),
                    //    Address = Capitalize(row[15].GetString()),
                    //    City = Capitalize(row[16].GetString()),
                    //    State = row[18].GetString(),
                    //    Zipcode = row[19].GetString()?.Substring(0, 5)
                    //});
                }
                catch
                {
                    continue;
                }
            }

            Console.WriteLine($"Scraped {doctors.Count} doctors from CMS data.");

            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "doctors.json");
            string outputJson = JsonSerializer.Serialize(doctors, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(jsonPath, outputJson);

            return doctors;
        }


        private static string Capitalize(string input)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input?.ToLower() ?? "");
        }
    }
}
