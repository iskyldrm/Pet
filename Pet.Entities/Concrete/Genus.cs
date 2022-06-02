using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Genus : IBaseEntity<int>, IEntity
    {
        public int Id { get; set; }
        public string GenusName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}