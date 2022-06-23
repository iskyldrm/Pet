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
    public class KindConfig : IEntityTypeConfiguration<Kind>
    {
        public void Configure(EntityTypeBuilder<Kind> builder)
        {
            builder.HasData
                (
                    new Kind { Id = 1, KindName = "Kedi", Familya = Families.Felines,Team = Orders.carnivorous, CreateTime = DateTime.Now,UpdateTime = DateTime.Now},
                    new Kind { Id = 2, KindName = "Köpek", Familya = Families.canines, Team = Orders.Omnivor, CreateTime = DateTime.Now, UpdateTime = DateTime.Now }
                    
                );
        }
    }
}
