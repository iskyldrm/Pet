using Pet.Entities.Concrete;

namespace Pet.Entities.Abstract
{
    public interface ILivingProfile
    {
        public string LivingName { get; set; }  //Canlı ismi
        public bool LivingGender { get; set; }  //Cinsiyet
        public byte LivingAge { get; set; }
    }
}
