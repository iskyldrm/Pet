namespace Pet.Entities.Abstract
{
    public abstract class LivingImage : IBaseEntity, IEntity
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Url { get; set; }
        public string ImageDescription { get; set; }
        public int LivingProfileId { get; set; }
        public virtual LivingProfile LivingProfile { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}