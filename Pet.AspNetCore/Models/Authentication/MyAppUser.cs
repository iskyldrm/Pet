using Microsoft.AspNetCore.Identity;
using Pet.Entities.Abstract;
using Pet.Entities.Concrete;

namespace Pet.AspNetCore.Models.Authentication
{
    public class MyAppUser : IdentityUser, IEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime Age { get; set; }
        public Guid AddressId { get; set; }
        public Address Addresss { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
