using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pet.Entities.Concrete;

namespace Pet.Entities.Configurations
{
    public class SehirlerConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(p => p.CityName)
                .HasMaxLength(50)
                .IsRequired(true);


        }
    }
}
