using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Advert : IBaseEntity<Guid>, IEntity
    {
        public Guid Id { get; set; }
        public string AdvertNo { get; set; } // ilan no
        public AdvertType AdvertType { get; set; }
        public string PetState { get; set; }
        public virtual List<Image>? Image { get; set; }
        public virtual List<Favorite> Favorites { get; set; }
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public int AddressId { get; set; }
        public virtual Address? Address { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }

    public enum AdvertType
    {
        KopekEsIlani,
        KediEsIlani
    }
}
