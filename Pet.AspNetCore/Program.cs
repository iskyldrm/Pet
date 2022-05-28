using Pet.AspNetCore.Models.DbContext;
using Pet.AspNetCore.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddControllersWithViews();
builder.Services.IdentityServerAyarlari();
builder.Services.CookieAyarlari();


var app = builder.Build();

app.UseStatusCodePages();
app.UseStaticFiles();
app.UseAuthentication();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
