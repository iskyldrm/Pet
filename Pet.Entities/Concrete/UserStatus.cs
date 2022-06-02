using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class UserStatus : IBaseEntity<int>, IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}