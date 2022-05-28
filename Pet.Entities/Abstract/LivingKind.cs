using Pet.Entities.Concrete;

namespace Pet.Entities.Abstract
{
    public abstract class LivingKind : IBaseEntity, IEntity
    {
        public int Id { get; set; }
        public int KindTeam { get; set; }
        public Orders Team { get; set; } //Takım
        public int KindFamilya { get; set; }
        public Families Familya { get; set; }
        public int KindGenus { get; set; }
        public virtual Genus Genus { get; set; } //cins
        public int KindRacial { get; set; }
        public virtual Racial Racial { get; set; } //ırkı
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
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
