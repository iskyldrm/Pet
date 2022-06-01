using Pet.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pet.Entities.Concrete
{
    public class Address : IBaseEntity, IEntity
    {
        public int Id { get; set; }
        
        public int CityId { get; set; }
        public virtual City? City { get; set; }
        public int DistrictId { get; set; }
        public virtual District? District { get; set; }
        public string? FullAdsress { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}