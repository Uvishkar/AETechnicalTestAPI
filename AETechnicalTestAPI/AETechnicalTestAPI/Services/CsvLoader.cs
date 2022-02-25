using AETechnicalTestAPI.Domain_Models;
using AETechnicalTestAPI.Services;
using CsvHelper.Configuration;
using LINQtoCSV;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AETechnicalTestAPI
{
    public class CsvLoader
    {   /*Loading Csv using a Csv helper library https://joshclose.github.io/CsvHelper/ */
        public static void CSVDataloader()
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
                UseFieldIndexForReadingData = true
            };

            var csvContext = new CsvContext();
            var vehicles = csvContext.Read<Vehicle>(@"C:\AE Technical Test\AE Technical Test API\AETechnicalTestAPI\AETechnicalTestAPI\AETechnicalTestAPI\AETechnicalTestAPI\Assets\Vehicles.csv", csvFileDescription);
            try
            {
                foreach (var vehicle in vehicles)
                {

                    var valid = Validation.CSVValidationChecks(vehicle);
                    if (valid)
                    {
                        var Tax = Tax_Calculation.Taxcalculator(vehicle);
                        var RoadWorthyCheck = RoadWorthy.RoadworthyCheck(vehicle);
                        SaveToDatabase(vehicle);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Generated. Details: " + ex.ToString());
            }
            



        }
        public static void SaveToDatabase(Vehicle vehicle)
        {


            string connectionString = "server =.; database = AETechnicalTestDb; Trusted_Connection = true";
            SqlConnection connection = new SqlConnection(@connectionString);
            string query = "INSERT into Vehicle (VehicleType,Make,Model,Year,WheelCount,FuelType,Active,Tax,RoadWorthyTestInterval) VALUES (@VehicleType,@Make,@Model,@Year,@WheelCount,@FuelType,@Active,@Tax,@RoadWorthyTestInterval)";
            SqlCommand command = new SqlCommand(query, connection);

         
            command.Parameters.AddWithValue("@VehicleType", vehicle.VehicleType);
            command.Parameters.AddWithValue("@Make", vehicle.Make);
            command.Parameters.AddWithValue("@Model", vehicle.Model);
            command.Parameters.AddWithValue("@Year", vehicle.Year);
            command.Parameters.AddWithValue("@WheelCount", vehicle.WheelCount);
            command.Parameters.AddWithValue("@FuelType", vehicle.FuelType);
            command.Parameters.AddWithValue("@Active", vehicle.Active);
            command.Parameters.AddWithValue("@Tax", vehicle.Tax);
            command.Parameters.AddWithValue("@RoadWorthyTestInterval", vehicle.RoadWorthyTestInterval);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                connection.Close();
            }

        }

    }
}

