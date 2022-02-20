using AETechnicalTestAPI.Models;
using System;

namespace AETechnicalTestAPI.Repositories
{
    public interface IVehiclesRepository
    {
        Task<List<Vehicle>> GetVehiclesAsync();
    }
}
