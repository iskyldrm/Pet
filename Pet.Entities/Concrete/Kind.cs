using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Kind : ILivingKind,IBaseEntity,IEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public int KindTeam { get; set; }
        public Orders Team { get; set; }
        public int KindFamilya { get; set; }
        public Families Familya { get; set; }
    }
}