using Pet.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Entities.Concrete
{
    public class Advert : IBaseEntity,IEntity
    {
        public int Id { get; set; }
        public string AdvertNo { get; set; } // ilan no
        public AdvertType AdvertType { get; set; }
        public string PetState { get; set; }
        public int LivingProfile { get; set; }
        public LivingProfile LivingProfiles { get; set; }
        public int ImageId { get; set; }
        public List<Image> Image { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int AddressId { get; set; }
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
