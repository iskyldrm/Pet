using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class District : IBaseEntity, IEntity
    {
        public int Id { get; set; }

        public string DistrictName { get; set; }
        public int CityId { get; set; }
        public virtual City? City { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}