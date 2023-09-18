using CourseCreator.Core.Services;
using CourseCreator.Core.Services.Interfaces;
using CourseCreator.Datalayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//IOC
#region IOC

builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IUserService, UserService>();
#endregion

builder.Services.AddRazorPages();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CourseCreatorContext>(options =>
{
    options.UseNpgsql(connectionString);
});

builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.MapRazorPages();
//app.MapGet("/", () => "Hello World!");
app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();