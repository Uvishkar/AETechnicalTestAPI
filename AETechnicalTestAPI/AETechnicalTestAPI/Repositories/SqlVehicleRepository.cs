using AETechnicalTestAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

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
    }
}
