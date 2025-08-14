using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using planMyMDVisit.Data;
using planMyMDVisit.Models.Domain;
using planMyMDVisit.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddCors(opt =>
//{
//    opt.AddPolicy("CorsPolicy", policyBuilder =>
//    {
//        policyBuilder.
//    });
//});

builder.Services.AddDbContext<PlanMyMDVisitContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MdVisitCon")));
//.EnableSensitiveDataLogging());

builder.Logging.AddConsole();

builder.Services.AddIdentity<User, IdentityRole<Guid>>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    options.Lockout.MaxFailedAccessAttempts = 5;
    options.User.RequireUniqueEmail = true;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
})
    .AddEntityFrameworkStores<PlanMyMDVisitContext>()
    .AddRoles<IdentityRole<Guid>>()
    .AddDefaultTokenProviders()
    .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<User, IdentityRole<Guid>>>();

builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IHealthCareTeamRepository, HealthCareTeamRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<PlanMyMDVisitContext>();
    dbContext.Database.Migrate();

    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

    var roles = new[] { "User", "Admin" };

    foreach (var role in roles)
    {
        var roleExist = await roleManager.RoleExistsAsync(role);

        if (!roleExist)
        {
            await roleManager.CreateAsync(new IdentityRole<Guid>(role));
        }
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:7189"));

app.UseAuthentication();

app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Patients}/{action=Show}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

//using(var scope = app.Services.CreateScope())
//{
//    var services = scope.ServiceProvider;
//    var context = services.GetRequiredService<PlanMyMDVisitContext>();

//    context.Database.Migrate();

//    var seeder = new DataSeeder(context);
//    await seeder.SeedDoctorsAsync();
//}

app.Run();
