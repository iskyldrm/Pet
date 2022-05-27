using System.ComponentModel.DataAnnotations;

namespace Pet.Entities.Abstract
{
    public abstract class LivingImage : IBaseEntity, IEntity
    {
        [Key]
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int LivingProfileId { get; set; }
        public virtual LivingProfile LivingProfile { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}