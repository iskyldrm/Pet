using Pet.Entities.Concrete;

namespace Pet.WEB.DTO
{
    public class AdvertDTO
    {
        public string AdvertNo { get; set; } // açıklama
        public AdvertType AdvertType { get; set; }
        public string PetState { get; set; }
        public virtual string Url { get; set; }
        public string LivingName { get; set; }
    }
}
