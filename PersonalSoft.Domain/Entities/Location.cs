﻿using System.ComponentModel.DataAnnotations;

namespace PersonalSoft.Domain.Entities
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
