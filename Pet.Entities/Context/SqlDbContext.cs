using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Entities.Context
{
    public class MySqlDbContext:DbContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Advert> Adverts { get; set; }
        DbSet<Cat> Cats { get; set; }
        DbSet<District> Districts { get; set; }
        DbSet<Dog> Dogs { get; set; }
        DbSet<Favorite> Favorites { get; set; }
        DbSet<Genus> Genus { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<Kind> Kinds { get; set; }
        DbSet<Racial> Racials { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserStatus> UserStatuses { get; set; }

        public MySqlDbContext(DbContextOptions<MySqlDbContext> options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;database=Pet;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
