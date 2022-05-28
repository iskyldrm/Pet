using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pet.AspNetCore.Models.Authentication;

namespace Pet.AspNetCore.Models.DbContext
{
    public class MyDbContext: IdentityDbContext<MyAppUser>
    {
        public MyDbContext(DbContextOptions<MyDbContext> db):base(db)
        {

        }
        
    }
}
