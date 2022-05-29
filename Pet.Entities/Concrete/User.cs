using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class User : IPerson, IBaseEntity, IEntity //Kullanıcı profili
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime Age { get; set; }
        public int UserStatusId { get; set; }
        public UserStatus UserStatus { get; set; }
        public int AddressId { get; set; }
        public virtual Address? Addresss { get; set; }
        public int LivingProfileId { get; set; }
        public virtual List<LivingProfile>? LivingProfile { get; set; }
        public int AdvertId { get; set; }
        public virtual List<Advert>? Advert { get; set; }
        public int FavoriteId { get; set; }
        public virtual List<Favorite>? Favorites { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        //public string Name { get; set; }
        //public string LastName { get; set; }
        //public bool Gender { get; set; }
        //public DateTime Age { get; set; }
        //public int AddressId { get; set; }
        //public Address Addresss { get; set; }
        //public DateTime CreateTime { get; set; }
        //public DateTime UpdateTime { get; set; }
    }
}