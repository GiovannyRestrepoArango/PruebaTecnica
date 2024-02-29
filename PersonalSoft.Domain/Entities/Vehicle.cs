using System.ComponentModel.DataAnnotations;

namespace PersonalSoft.Domain.Entities
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public string Plate { get; set; } = string.Empty;
    }
}
