using Pet.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Entities.Abstract
{
    public abstract class LivingThing : IBaseEntity
    {
        public int Id { get; set; }
        public string LivingName { get; set; }  //Canlı ismi
        public string LivingGenus { get; set; } //Cins
        public string LivingRacial { get; set; }//Irk
        public bool LivingGender { get; set; }  //Cinsiyet
        public byte LivingAge { get; set; }
        public int LivingImageId { get; set; }
        public List<LivingImage> LivingsImage { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
