using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Genus : IBaseEntity<int>, IEntity
    {
        public int Id { get; set; }
        public string GenusName { get; set; }
        public bool GenusType { get; set; } // true kedi false köpek
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}