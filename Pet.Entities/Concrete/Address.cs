using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Address : IBaseEntity, IEntity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public City City { get; set; }
        public int DistrictName { get; set; }
        public District District { get; set; }
        public string? FullAdsress { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}