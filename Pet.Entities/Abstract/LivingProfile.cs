using Pet.Entities.Concrete;

namespace Pet.Entities.Abstract
{
    public abstract class LivingProfile : IBaseEntity, IEntity
    {
        public int Id { get; set; }
        public string LivingName { get; set; }  //Canlı ismi
        public int LivingKind { get; set; }
        public virtual Kind Kind { get; set; }
        public bool LivingGender { get; set; }  //Cinsiyet
        public byte LivingAge { get; set; }
        public int LivingImageId { get; set; }
        public virtual List<LivingImage> LivingsImage { get; set; }
        public int UserId { get; set; }
        public virtual User Users { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
