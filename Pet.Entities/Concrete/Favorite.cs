using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Favorite : IBaseEntity, IEntity
    {
        public int Id { get; set; }
        public string Discription { get; set; }
        public int AdvertId { get; set; }
        public virtual Advert? Advert { get; set; }
        public virtual List<User>? Users { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}