using System.ComponentModel.DataAnnotations;

namespace PersonalSoft.Domain.Entities
{
    public class LocationXVehicle
    {
        [Key]
        public int Id { get; set; }

        public int LocationId { get; set; }

        public int VehicleId { get; set; }

        public DateTime? StartRental { get; set; }

        public DateTime? EndRental { get; set; }

        public virtual Location? Location { get; set; }

        public virtual Vehicle? Vehicle { get; set; }
    }
}
