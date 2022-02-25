using AETechnicalTestAPI.Domain_Models;
using AETechnicalTestAPI.Enums;

namespace AETechnicalTestAPI.Services
{
    public class RoadWorthy
    {

        public static string RoadworthyCheck(Vehicle vehicle)
        {
            //Road worthy interval check for vehicles according to their Type and age

            int Age = DateTime.Today.Year - vehicle.Year;
            if (vehicle.VehicleType.Equals("Car") && Age < 10)
            {
                return vehicle.RoadWorthyTestInterval = "2 years";
            }
            else if (vehicle.VehicleType.Equals("Car") && Age > 10)
            {
                return vehicle.RoadWorthyTestInterval = "1 year";
            }
            else if (vehicle.VehicleType.Equals("Bike") && Age < 5)
            {
                return vehicle.RoadWorthyTestInterval = "1 year";
            }
            else if (vehicle.VehicleType.Equals("Bike") && Age > 5)
            {
                return vehicle.RoadWorthyTestInterval = "6 months";
            }
            else
            {
                return vehicle.RoadWorthyTestInterval = "Not applicable";
            }


        }
    }
}
