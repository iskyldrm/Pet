using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Kind : IBaseEntity<int>, IEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public virtual List<Living> Livings { get; set; }
        public int KindTeam { get; set; }
        public Orders Team { get; set; }
        public int KindFamilya { get; set; }
        public Families Familya { get; set; }
    }

    public enum Orders
    {
        carnivorous, //Etçil
        herbivorous  //Otçul
    }
    public enum Families
    {
        Felines, //Kedigiller
        canines  //Köpekgiller
    }
}