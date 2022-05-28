var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStatusCodePages();
app.UseStaticFiles();
app.MapGet("/", () => "Hello World!");

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
