using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AETechnicalTestAPI.Models
{
    public class Vehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID {get; set;}
        public string VehicleType { get; set; } 
        public string Make { get; set; } 
        public string Model { get; set; } 
        public int Year { get; set; }
        public int WheelCount { get; set; }
        public string FuelType { get; set; } 
        public bool Active { get; set; }
        public int Tax { get; set; }
        public string RoadWorthyTestInterval { get; set; } 
    }
}
