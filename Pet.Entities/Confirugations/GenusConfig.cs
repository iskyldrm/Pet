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
                new Genus { Id = 1,  GenusType=true,GenusName = "Amerikan Shorthair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 2,  GenusType=true,GenusName = "American Curl", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 3,  GenusType=true,GenusName = "Balinese", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 4,  GenusType=true,GenusName = "California Spangled", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 5,  GenusType=true,GenusName = "Chartreux", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 6,  GenusType=true,GenusName = "Ragdoll Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 7,  GenusType=true,GenusName = "Mavi Rus kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 8,  GenusType=true,GenusName = "Maine Coon", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 9,  GenusType=true,GenusName = "İran kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 10, GenusType=true, GenusName = "British Shorthair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 11, GenusType=true, GenusName = "California Spangled", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 12, GenusType=true, GenusName = "Munchkin", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 13, GenusType=true, GenusName = "Scottish Fold", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 14, GenusType=true, GenusName = "Norveç Orman Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 15, GenusType=true, GenusName = "Sibirya Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 16, GenusType=true, GenusName = "Savannah", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 17, GenusType=true, GenusName = "Amerikan Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 18, GenusType=true, GenusName = "Exotic Shorthair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 19, GenusType=true, GenusName = "Ankara kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 20, GenusType=true, GenusName = "Himalayan Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 21, GenusType=true, GenusName = "Kısa Tüylü Kedi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 22, GenusType=true, GenusName = "Birman Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now }, 
                new Genus { Id = 23, GenusType=true, GenusName = "Habeş Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 24, GenusType=true, GenusName = "Bombay Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 25, GenusType=true, GenusName = "Kinkalow", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 26, GenusType=true, GenusName = "Oriental Shorthair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 27, GenusType=true, GenusName = "Ragamuffin", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 28, GenusType=true, GenusName = "Somali Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 29, GenusType=true, GenusName = "Singapura", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 30, GenusType=true, GenusName = "British Longhair", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 31, GenusType=true, GenusName = "Toyger", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 32, GenusType=true, GenusName = "Van Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 33, GenusType=true, GenusName = "manks kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 34, GenusType=true, GenusName = "Donskoy Kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 35, GenusType=true, GenusName = "Havana kedisi", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 36, GenusType=true, GenusName = "Ocicat", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 37, GenusType=true, GenusName = "Balinese", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 38, GenusType=true, GenusName = "Laperm", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 39, GenusType=true, GenusName = "Selkirk Rex", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 40, GenusType = false, GenusName = "Buldog", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 41, GenusType = false, GenusName = "Labrador retriever", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 42, GenusType = false, GenusName = "Alman çoban köpeği", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 43, GenusType = false, GenusName = "Kaniş", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 44, GenusType = false, GenusName = "Golden Retriever", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 45, GenusType = false, GenusName = "Chihuahua", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 46, GenusType = false, GenusName = "Fransız buldoğu", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 47, GenusType = false, GenusName = "Bişon çuha köpeği", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 48, GenusType = false, GenusName = "Boksör", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 49, GenusType = false, GenusName = "Border collie", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 50, GenusType = false, GenusName = "Sibirya kurdu", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 51, GenusType = false, GenusName = "Pug", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 52, GenusType = false, GenusName = "Amerikan Staffordshire teriyeri", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 53, GenusType = false, GenusName = "Boston Terrier", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 54, GenusType = false, GenusName = "Cavalier King Charles Spaniel", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 55, GenusType = false, GenusName = "Pomeranian", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 56, GenusType = false, GenusName = "Yorkshire teriyeri", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 57, GenusType = false, GenusName = "Bull teriyer", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 58, GenusType = false, GenusName = "İngiliz Cocker Spaniel", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 59, GenusType = false, GenusName = "Amerikan Eskimo Köpeği", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 60, GenusType = false, GenusName = "Danua", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 61, GenusType = false, GenusName = "Malta köpeği", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 62, GenusType = false, GenusName = "Çov-çov", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 63, GenusType = false, GenusName = "Affenpinscher", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 64, GenusType = false, GenusName = "Basenji", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 65, GenusType = false, GenusName = "Dakhund", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 66, GenusType = false, GenusName = "Bretonya epanyölü", CreateTime = DateTime.Now, UpdateTime = DateTime.Now },
                new Genus { Id = 67, GenusType = false, GenusName = "Bulmastif", CreateTime = DateTime.Now, UpdateTime = DateTime.Now }

            );
        }
    }
}
