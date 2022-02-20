namespace AETechnicalTestAPI.Domain_Models
{

    
    public class Vehicle
    {
        
        public Guid ID { get; set; }
        //[CsvColumn(Name = "TYPE", FieldIndex = 1)]
        public string VehicleType { get; set; } = String.Empty;
        //[CsvColumn(Name = "Make", FieldIndex = 2)]
        public String Make { get; set; } = String.Empty;
        //[CsvColumn(Name = "Make", FieldIndex = 2)]
        public String Model { get; set; } = String.Empty;
        //CsvColumn(Name = "Year", FieldIndex = 3)]
        public int Year { get; set; }
        //[CsvColumn(Name = "WheelCount", FieldIndex = 4)]
        public int WheelCount { get; set; }
        //CsvColumn(Name = "FuelType", FieldIndex = 5)]
        public String FuelType { get; set; } = String.Empty;
        // [CsvColumn(Name = "Active", FieldIndex = 6)]
        public bool Active { get; set; }
        public int Tax { get; set; }
    }
}
