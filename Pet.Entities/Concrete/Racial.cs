using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Racial : IBaseEntity, IEntity
    {
        public Guid Id { get; set; }
        public string RacialName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}