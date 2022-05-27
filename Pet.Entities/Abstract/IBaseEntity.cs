﻿using System.ComponentModel.DataAnnotations;

namespace Pet.Entities.Abstract
{
    public interface IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}
