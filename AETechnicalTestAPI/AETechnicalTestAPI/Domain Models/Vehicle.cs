using System.ComponentModel.DataAnnotations.Schema;
using LINQtoCSV;
using System;
using System.ComponentModel.DataAnnotations;

namespace AETechnicalTestAPI.Domain_Models
{
    [Serializable]
    public class Vehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        [CsvColumn(Name = "TYPE", FieldIndex = 1)]
        public string VehicleType { get; set; } = string.Empty;

       [CsvColumn(Name = "MAKE", FieldIndex = 2)]
        public string Make { get; set; } = string.Empty;

        [CsvColumn(Name = "MODEL", FieldIndex = 3)]
        public string Model { get; set; } = string.Empty;

        [CsvColumn(Name = "YEAR", FieldIndex = 4)]
        public int Year { get; set; }

        [CsvColumn(Name = "WHEELCOUNT", FieldIndex = 5)]
        public int WheelCount { get; set; }

        [CsvColumn(Name = "FUELTYPE", FieldIndex = 6)]
        public string FuelType { get; set; } = string.Empty;

        [CsvColumn(Name = "ACTIVE", FieldIndex = 7)]

        public bool Active { get; set; }

        public int Tax { get; set; }
        public string RoadWorthyTestInterval { get; set; } = string.Empty;
    }
}
