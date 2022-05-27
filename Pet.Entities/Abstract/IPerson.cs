using Pet.Entities.Concrete;

namespace Pet.Entities.Abstract
{
    public interface IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime Age { get; set; }
        public int AddressId { get; set; }
        public Address Addresss { get; set; }
    }
}
