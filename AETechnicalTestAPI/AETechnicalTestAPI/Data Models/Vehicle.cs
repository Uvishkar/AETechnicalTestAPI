using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AETechnicalTestAPI.Models
{
    public class Vehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID {get; set;}
        public string VehicleType { get; set; } = String.Empty;
        public String Make { get; set; } = String.Empty;
        public String Model { get; set; } = String.Empty;
        public int Year { get; set; }
        public int WheelCount { get; set; }
        public String FuelType { get; set; } = String.Empty;
        public bool Active { get; set; }
        public int Tax { get; set; }
        public string RoadWorthyTestInterval { get; set; } = string.Empty;
    }
}
