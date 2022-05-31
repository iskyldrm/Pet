using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Genus : IBaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string GenusName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}