namespace AETechnicalTestAPI.Domain_Models
{
    public class UpdateVehicleRequest
    {
        public int ID { get; set; }
        public string Make { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int Year { get; set; }
        public int WheelCount { get; set; }
        public string FuelType { get; set; } = string.Empty;
        public bool Active { get; set; }
        public int Tax { get; set; }
        public string RoadWorthyTestInterval { get; set; } = string.Empty;
    }
}
