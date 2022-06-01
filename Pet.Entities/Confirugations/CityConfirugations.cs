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
    public class CityConfirugations : IEntityTypeConfiguration<City>
    {

        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.CityName).HasMaxLength(100).IsRequired();
            builder.HasData
            (
                new City { Id=1, CityName = "İstanbul",CityNumber = 34},
                new City { Id=2, CityName = "Kocaeli", CityNumber = 41 }
            );
            
        }
    }
}
