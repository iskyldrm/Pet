using Pet.Entities.Abstract;

namespace Pet.Entities.Concrete
{
    public class Kind : IBaseEntity<int>, IEntity
    {
        public int Id { get; set; }
        public string KindName { get; set; }    
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public virtual List<Living>? Livings { get; set; }
        public Orders Team { get; set; }
        public Families Familya { get; set; }
    }

    public enum Orders
    {
        carnivorous, //Etçil
        herbivorous,  //Otçul
        Omnivor    // Hepçil
    }
    public enum Families
    {
        Felines, //Kedigiller
        canines  //Köpekgiller
    }
}