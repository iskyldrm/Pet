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
    public class GenusConfig : IEntityTypeConfiguration<Genus>
    {
        public void Configure(EntityTypeBuilder<Genus> builder)
        {
            builder.HasData(
                new Genus { Id = 1, GenusName = "Amerikan Shorthair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 2, GenusName = "American Curl", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 3, GenusName = "Balinese", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 4, GenusName = "California Spangled", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 5, GenusName = "Chartreux", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 6, GenusName = "Ragdoll Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 7, GenusName = "Mavi Rus kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 8, GenusName = "Maine Coon", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 9, GenusName = "İran kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 10, GenusName = "British Shorthair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 11, GenusName = "California Spangled", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 12, GenusName = "Munchkin", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 13, GenusName = "Scottish Fold", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 14, GenusName = "Norveç Orman Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 15, GenusName = "Sibirya Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 16, GenusName = "Savannah", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 17, GenusName = "Amerikan Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 18, GenusName = "Exotic Shorthair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 19, GenusName = "Ankara kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 20, GenusName = "Himalayan Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 21, GenusName = "Kısa Tüylü Kedi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 22, GenusName = "Birman Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now }, 
                new Genus { Id = 23, GenusName = "Habeş Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 24, GenusName = "Bombay Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 25, GenusName = "Kinkalow", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 26, GenusName = "Oriental Shorthair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 27, GenusName = "Ragamuffin", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 28, GenusName = "Somali Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 29, GenusName = "Singapura", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 30, GenusName = "British Longhair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 31, GenusName = "Toyger", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 32, GenusName = "Van Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 33, GenusName = "manks kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 34, GenusName = "Donskoy Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 35, GenusName = "Havana kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 36, GenusName = "Ocicat", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 37, GenusName = "Balinese", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 38, GenusName = "Laperm", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 39, GenusName = "Selkirk Rex", CreateTime = DateTime.Now, UpdateTime = DateTime.Now }

            );
        }
    }
}
