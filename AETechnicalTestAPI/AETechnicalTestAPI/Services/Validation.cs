using AETechnicalTestAPI.Domain_Models;
using AETechnicalTestAPI.Enums;
using System.Data;
using System.Text.RegularExpressions;

namespace AETechnicalTestAPI.Services
{
    public class Validation
    {
        public static bool CSVValidationChecks(Vehicle vehicle)
        {
            //Checking if Vehicle type, Make and Model have valid values
            var regexItem = new Regex(@"^[a=zA-Z -]");
            if (vehicle.VehicleType.Any(x => !char.IsLetter(x))
                ||  !regexItem.IsMatch(vehicle.Make)
                || !regexItem.IsMatch(vehicle.Model)
                )
            {
                return false;
            }
            //checking for a valid year
            if (vehicle.Year == 0)              
            {
                return false;
            }

            //Valiation check for Fuel Type
            if (vehicle.FuelType != FuelTypes.Petrol.ToString() && vehicle.FuelType != FuelTypes.Diesel.ToString() && vehicle.FuelType != FuelTypes.None.ToString())
            {
                return false;
            }

            return true;
        }
    }
}
