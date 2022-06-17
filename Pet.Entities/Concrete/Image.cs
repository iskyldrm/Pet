using Pet.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet.Entities.Concrete
{
    public class Image : IBaseEntity<Guid>,IEntity
    {
        public Guid Id { get; set; }
        public string? ImagePath { get; set; }
        public string Url { get; set; }
        public string? ImageDescription { get; set; }
        public virtual Living? Living { get; set; }
        public Advert Advert { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}

