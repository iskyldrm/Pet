using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Racial : IBaseEntity<int>, IEntity
    {
        public int Id { get; set; }
        public string RacialName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}