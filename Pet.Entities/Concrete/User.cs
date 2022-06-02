using Microsoft.AspNetCore.Identity;
using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class User : IdentityUser,IEntity //Kullanıcı profili
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime Age { get; set; }
        public int UserStatusId { get; set; }
        public UserStatus? UserStatus { get; set; }
        public int AddressId { get; set; }
        public virtual Address? Addresss { get; set; }
        public virtual List<Living>? Livings { get; set; }
        public virtual List<Advert>? Advert { get; set; }
        public virtual List<Favorite>? Favorites { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        
    }
}