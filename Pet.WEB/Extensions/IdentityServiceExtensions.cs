using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pet.BL.Abstract;
using Pet.BL.Concrete;
using Pet.DAL.Abstract;
using Pet.DAL.Concrete;
using Pet.Entities.Concrete;
using Pet.Entities.Context;
using Pet.WEB.Models;
using System.Configuration;

namespace Pet.WEB.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection IdentitySettings(this IServiceCollection services)
        {
            var constr = @"Server=(localdb)\mssqllocaldb;database=Pet;trusted_connection=true";
            services.AddDbContext<SqlDbContext>
            (options => options.UseSqlServer(constr));

            services.AddIdentity<User, UserRole>().AddDefaultUI().AddEntityFrameworkStores<SqlDbContext>().
                AddDefaultTokenProviders();

            services.AddSingleton<IEmailSender, EmailSender>();
            services.AddScoped<IdentityUser, User>();
            services.AddScoped<ICityManager, CityManager>();
            services.AddScoped<IDistrictManager, DistrictManager>();
            services.AddScoped<IKindManager, KindManager>();
            services.AddScoped<IGenusManager, GenusManager>();
            services.AddScoped<ILivingManager, LivingManager>();
            services.AddScoped<IImageManager, ImageManager>();
            services.AddScoped<IAdvertManager, AdvertManager>();


            return services;
        }

        public static IServiceCollection UserPasswordSettings(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                //Olusacak sifre icerisinde rakam olsunmu ?
                options.Password.RequireDigit = true;
                //Kucuk karakter olsunmu?
                options.Password.RequireLowercase = true;
                //Minumum şifre uzunlugu
                options.Password.RequiredLength = 6;
                options.Password.RequireNonAlphanumeric = false;
                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                //UserName icerisinde olmasini istediginiz karakterler burada a-z kadar yazilmalidir
                //options.User.AllowedUserNameCharacters="";

                //Girilen Mail adresinden sadece bir adet olacak
                options.User.RequireUniqueEmail = true;
                options.SignIn.RequireConfirmedAccount = true;

                options.SignIn.RequireConfirmedEmail = true;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

                //AllowOnlyAlphanumericUserNames = false 
            });
            return services;
        }


    }
}
