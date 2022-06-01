using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Advert : IBaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string AdvertNo { get; set; } // ilan no
        public AdvertType AdvertType { get; set; }
        public string PetState { get; set; }
        public Guid LivingProfileId { get; set; }
        public LivingProfile LivingProfiles { get; set; }
        public List<Image> Image { get; set; }
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }

    public enum AdvertType
    {
        KopekEsIlani,
        KediEsIlani
    }
}
