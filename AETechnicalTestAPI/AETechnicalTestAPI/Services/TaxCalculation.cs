using AETechnicalTestAPI.Domain_Models;
using AETechnicalTestAPI.Enums;

namespace AETechnicalTestAPI.Services
{
    public class Tax_Calculation
    {
        public static int Taxcalculator(Vehicle vehicle)
        {
            //Adding Tax to Vehiles according to the Vehicle and Fuel Type
            switch ((vehicle.VehicleType, vehicle.FuelType))
            {
                case ("Car", "Diesel"):
                    return vehicle.Tax = 1500;
                   
                case ("Car", "Petrol"):
                    return vehicle.Tax = (int)(1500 + (1500 * 0.20));
               
                case ("Boat", "Diesel"):
                    return vehicle.Tax = 2000;
                  
                case ("Boat", " Petrol"):
                    return vehicle.Tax = 2000 +(2000*15);
                 
                case ("Bicycle", "None"):
                    return vehicle.Tax = 0;
                
                case ("Bike", "Diesel"):
                    return vehicle.Tax = 1000;
                  
                case ("Bike", "Petrol"):
                    return vehicle.Tax = (int)(1000 + (1000 * 0.20));
                   
                case ("Plane", "Diesel"):
                    return vehicle.Tax = 5000;
                  
                case ("Plane", "Petrol"):
                    return vehicle.Tax = 5000;

                default:
                    return vehicle.Tax = 0;
            }
  
        }

    }
}
