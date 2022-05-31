using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class UserStatus : IBaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}