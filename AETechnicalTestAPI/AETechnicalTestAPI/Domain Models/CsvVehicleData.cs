using System.ComponentModel.DataAnnotations.Schema;

namespace AETechnicalTestAPI.Domain_Models
{
    public class CsvVehicleData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        public string TYPE { get; set; } = String.Empty;
        public String MAKE{ get; set; } = String.Empty;
        public String MODEL { get; set; } = String.Empty;
        public int YEAR { get; set; }
        public int WHEELCOUNT { get; set; }
        public String FUELTYPE { get; set; } = String.Empty;
        public bool ACTIVE { get; set; }
        public int Tax { get; set; }
        public string RoadWorthyTestInterval { get; set; } = string.Empty;

    }
}
