using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pet.Entities.Concrete;
using System.Reflection;

namespace Pet.Entities.Context
{
    public class SqlDbContext : IdentityDbContext<User>
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Living> Livings { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Genus> Genus { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Kind> Kinds { get; set; }
        public DbSet<Racial> Racials { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public SqlDbContext()
        {

        }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;database=Pet;trusted_connection=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
