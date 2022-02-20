namespace AETechnicalTestAPI.Domain_Models
{
    public class CsvVehicleData
    {
        public string TYPE { get; set; } = String.Empty;
     
        public String MAKE{ get; set; } = String.Empty;
      
        public String MODEL { get; set; } = String.Empty;
     
        public int YEAR { get; set; }
       
        public int WHEELCOUNT { get; set; }
   
        public String FUELTYPE { get; set; } = String.Empty;
    
        public bool ACTIVE { get; set; }
    }
}
