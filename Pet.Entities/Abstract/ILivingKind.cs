using Pet.Entities.Concrete;

namespace Pet.Entities.Abstract
{
    public interface ILivingKind
    {
        public int KindTeam { get; set; }
        public Orders Team { get; set; } //Takım
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
