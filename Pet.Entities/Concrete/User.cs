using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class User : IPerson, IBaseEntity, IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime Age { get; set; }
        public int AddressId { get; set; }
        public Address Addresss { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}