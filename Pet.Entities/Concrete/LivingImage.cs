using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class LivingImage : IBaseEntity
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int LivingThingId { get; set; }
        public LivingThing LivingThings { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}