using Pet.Entities.Concrete;

namespace Pet.Entities.Abstract
{
    public abstract class LivingProfile : IBaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string LivingName { get; set; }  //Canlı ismi
        public Guid LivingKind { get; set; }
        public virtual Kind Kind { get; set; }
        public bool LivingGender { get; set; }  //Cinsiyet
        public byte LivingAge { get; set; }
        public virtual List<Image> Image { get; set; }
        public string UserId { get; set; }
        public virtual User? User { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
