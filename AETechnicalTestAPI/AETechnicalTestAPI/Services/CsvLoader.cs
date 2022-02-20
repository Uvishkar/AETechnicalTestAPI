using AETechnicalTestAPI.Domain_Models;
using CsvHelper;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using AETechnicalTestAPI.Services;

namespace AETechnicalTestAPI
{
    public class CsvLoader
    {
        public static void GetDataTabletFromCSVFile()
        {
            using var streamReader = File.OpenText("C:/AE Technical Test/AE Technical Test API/AETechnicalTestAPI/AETechnicalTestAPI/AETechnicalTestAPI/AETechnicalTestAPI/Assets/Vehicles.csv");
            using var csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);

            var vehicles = csvReader.GetRecords<object>();





            List<CsvVehicleData> csvVehicleList = new List<CsvVehicleData>();
            var csv = new List<string[]>();
            var lines = System.IO.File.ReadAllLines(@"C:/AE Technical Test/AE Technical Test API/AETechnicalTestAPI/AETechnicalTestAPI/AETechnicalTestAPI/AETechnicalTestAPI/Assets/Vehicles.csv");
            foreach (string line in lines)
            {
                csv.Add(line.Split(';'));
            }

            foreach (var item in csv)
            {
                var valid = Validation.CSVValidationChecks(item);
                if (valid)
                {
                    CsvVehicleData csvVehicleData = new CsvVehicleData()
                    {
                        TYPE = Convert.ToString(item[0]),
                        MAKE = Convert.ToString(item[1]),
                        MODEL = Convert.ToString(item[2]),
                        YEAR = Convert.ToInt32(item[3]),
                        WHEELCOUNT = Convert.ToInt32(item[4]),
                        FUELTYPE = Convert.ToString(item[5]),
                        ACTIVE = Convert.ToBoolean(item[6])
                    };
                    csvVehicleList.Add(csvVehicleData);
                }
            }

            //InsertDataIntoSQLServerUsingSQLBulkCopy(csvVehicleList)
        }

        public static void InsertDataIntoSQLServerUsingSQLBulkCopy(List<CsvVehicleData> csvVehicleDataList)
        {
            using (SqlConnection dbConnection = new SqlConnection("server =.; database = AETechnicalTestDb; Trusted_Connection = true"))
            {
                dbConnection.Open();

                string insertStmt = "INSERT INTO dbo.Vehicle(REPORT_ID, ROLE_ID, CREATED_BY, CREATED) " +
                    "VALUES(@ReportID, @RoleID, 'SYSTEM', CURRENT_TIMESTAMP)";

                //using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                //{
                //    s.DestinationTableName = "Vehicle";

                //    //obj

                //    new Vehicle()
                //    {
                //        ID = new Guid(),
                //        Make = "" ,
                //        Model = "",
                //        VehicleType = "",
                //        FuelType = "",
                //        Year = 1,
                //        WheelCount = 4,
                //        Tax = 3,
                //        Active = true
                //    };

                //    //add to our liost

                //    //vehicle.save()

                //    foreach (var column in csvFileData.Columns)
                //        s.ColumnMappings.Add(column.ToString(), column.ToString());
                //    s.WriteToServer(csvFileData);
                //}
            }
        }
    }
}
