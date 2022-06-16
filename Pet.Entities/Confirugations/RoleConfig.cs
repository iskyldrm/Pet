using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Entities.Confirugations
{
    public class RoleConfig : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData
                (
                    new UserRole { Name = "Admin" },
                    new UserRole { Name = "BasicUser" },
                    new UserRole { Name = "MidUser" },
                    new UserRole { Name = "HighUser" },
                    new UserRole { Name = "Creator" },
                    new UserRole { Name = "Editor" }
                );
        }
    }
}
