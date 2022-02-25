using AETechnicalTestAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AETechnicalTestAPI.Repositories
{
    public class SqlVehicleRepository : IVehiclesRepository
    {
        private readonly VehicleContext context;

        public SqlVehicleRepository(VehicleContext context)
        {
            this.context = context;
        }
        public async Task<List<Vehicle>> GetVehiclesAsync()
        {
            return await context.Vehicle.ToListAsync();
        }

        public async Task<Vehicle> GetVehicleAsync(int ID)
        {
            return await context.Vehicle.FirstOrDefaultAsync(x => x.ID == ID);

        }
        public async Task<bool> Exists(int ID)
        {
            return await context.Vehicle.AnyAsync(x => x.ID == ID);
        }



        public async Task<Vehicle> DeleteVehicle(int ID)
        {
            var Vehicle = await GetVehicleAsync(ID);

            if (Vehicle != null)
            {
                context.Vehicle.Remove(Vehicle);
                await context.SaveChangesAsync();
                return Vehicle;
            }

            return null;
        }

        public async Task<Vehicle> AddVehicle(Vehicle request)
        {
            var vehicle = await context.Vehicle.AddAsync(request);
            await context.SaveChangesAsync();
            return vehicle.Entity;
        }

        public async Task<Vehicle> UpdateVehicle(int ID, Domain_Models.Vehicle vehicle)
        {
            var existingVehicle = await GetVehicleAsync(ID);
            if (existingVehicle != null)
            {
                existingVehicle.VehicleType = vehicle.VehicleType;
                existingVehicle.Make = vehicle.Make;
                existingVehicle.Model = vehicle.Model;
                existingVehicle.Year = vehicle.Year;
                existingVehicle.WheelCount = vehicle.WheelCount;
                existingVehicle.FuelType = vehicle.FuelType;
                existingVehicle.Active = vehicle.Active;
                existingVehicle.Tax = vehicle.Tax;
                existingVehicle.RoadWorthyTestInterval = vehicle.RoadWorthyTestInterval;

                await context.SaveChangesAsync();
                return existingVehicle;
            }

            return null;
        }



    }
}
