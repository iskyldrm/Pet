using Microsoft.AspNetCore.Identity;
using Pet.WEB.Extensions;
using Pet.WEB.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.IdentitySettings();
builder.Services.UserPasswordSettings();
builder.Services.AddMvc();
builder.Services.AddHealthChecks();
//builder.Services.Configure<IdentityOptions>(x =>
//{
//    x.SignIn.RequireConfirmedAccount = true;
//});
builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudOptions"));

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

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
app.UseAuthentication(); ;

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    // Part 2: add this call.
    endpoints.MapRazorPages();
});

app.MapAreaControllerRoute(
            name: "areas",
            areaName:"Identity",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                        );
app.MapAreaControllerRoute(
            name: "areas",
            areaName: "Pet",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                        );
app.MapAreaControllerRoute(
            name: "areas",
            areaName: "Adverts",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                        );
app.MapAreaControllerRoute(
            name: "areas",
            areaName: "Profile",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                        );

app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
