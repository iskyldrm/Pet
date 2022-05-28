using Pet.AspNetCore.Models.DbContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pet.AspNetCore.Models.Authentication;


namespace Pet.AspNetCore.Extensions
{
    public static class AddIdentityExtension
    {
        
        public static IServiceCollection IdentityServerAyarlari(this IServiceCollection services)
        {
            string conStr = @"server=(localdb)\mssqllocaldb;Database=Pet;Trusted_Connection=True;";

            // Identity Server Database ayarlarini IOC Container'ina register ediyoruz
            services.AddDbContext<MyDbContext>(options => options.UseSqlServer(conStr));

            // Benim olusturdugum Myuser class'ina gore calisacaktir
            // IdentityRole default halini kullansin
            // Bu Identity Tablolarini hangi dbcontext uzerinden olusturulacagi bilgisini geciyoruz

            services.AddIdentity<MyAppUser, IdentityRole>()
                .AddEntityFrameworkStores<MyDbContext>()
                .AddDefaultTokenProviders(); // Email confirm ve password degisikliginde uretilecek token ayari


            services.Configure<IdentityOptions>(options =>
            {
                //Olusacak sifre icerisinde rakam olsunmu ?
                options.Password.RequireDigit = true;
                //Kucuk karakter olsunmu?
                options.Password.RequireLowercase = true;
                //Minumum şifre uzunlugu
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                //UserName icerisinde olmasini istediginiz karakterler burada a-z kadar yazilmalidir
                //options.User.AllowedUserNameCharacters="";

                //Girilen Mail adresinden sadece bir adet olacak
                options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedEmail = true;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

                //AllowOnlyAlphanumericUserNames = false

            });



            return services;
        }
        public static IServiceCollection CookieAyarlari(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Account/Login";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccesDenied";
                options.Cookie.HttpOnly = true; // Tarayicidaki diger scriptler bu cookie'yi okuyamasin
                options.Cookie.Name = "FBU.Web8.Identity";
                options.Cookie.SameSite = SameSiteMode.Strict;// Bizim tarayicimiz disinda kullanimini engeller.
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);//Cookie gecerlilik suresi
            });

            return services;
        }

    }
}
