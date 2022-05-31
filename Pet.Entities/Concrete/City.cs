using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class City : IBaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public byte CityNumber { get; set; } //plaka no
        public string CityName { get; set; }
        public virtual List<District>? Districts { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}