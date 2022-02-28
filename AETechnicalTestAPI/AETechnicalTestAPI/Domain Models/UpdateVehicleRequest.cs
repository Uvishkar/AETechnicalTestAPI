namespace AETechnicalTestAPI.Domain_Models
{
    public class UpdateVehicleRequest
    {

        public string vehicleType { get; set; } = string.Empty;
        public string make { get; set; } = string.Empty;
        public string model { get; set; } = string.Empty;
        public int year { get; set; }
        public int wheelCount { get; set; }
        public string fuelType { get; set; } = string.Empty;
        public bool active { get; set; }
        public int tax { get; set; }
        public string roadWorthyTestInterval { get; set; } = string.Empty;
    }
}
