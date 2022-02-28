using AETechnicalTestAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AETechnicalTestAPI.Repositories
{
    public interface IVehiclesRepository
    {
        Task<List<Vehicle>>GetVehiclesAsync();
        Task<Vehicle> GetVehicleAsync(int ID);
        Task<bool> Exists(int ID);
        Task<Vehicle> DeleteVehicle(int ID);
        Task<Vehicle> AddVehicle(Vehicle request);
        Task<Vehicle> UpdateVehicle(int iD, Vehicle vehicle);
    }
}
