using Pet.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Entities.Concrete
{
    public class Living : IBaseEntity<Guid>,IEntity
    {
        public Guid Id { get; set; }
        public string LivingName { get; set; }
        public bool LivingGender { get; set; }
        public byte LivingAge { get; set; }
        public int KindId { get; set; }
        public Kind Kind { get; set; }
        public int GenusId { get; set; }
        public Genus Genus { get; set; }
        public List<Image> Images { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
