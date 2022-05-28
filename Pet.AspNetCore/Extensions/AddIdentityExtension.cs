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
            string constr = @"server=(localdb)\mssqllocaldb;database=Pet;Trusted_Connection=true";

            // Identity Server Database ayarlarini IOC Container'ina register ediyoruz
            services.AddDbContext<MyDbContext>(db => db.UseSqlServer(constr));

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

    }
}
