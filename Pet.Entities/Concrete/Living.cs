using Pet.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Entities.Concrete
{
    public class Living : ILivingProfile, IBaseEntity,IEntity
    {
        public int Id { get; set; }
        public string LivingName { get; set; }
        public bool LivingGender { get; set; }
        public byte LivingAge { get; set; }
        public int RacialId { get; set; }
        public Racial Racial { get; set; }
        public int GenusId { get; set; }
        public Genus Genus { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        
    }
}
