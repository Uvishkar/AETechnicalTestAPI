using Microsoft.EntityFrameworkCore;

namespace AETechnicalTestAPI.Models
{
    public class VehicleContext : DbContext
    {

        public VehicleContext(DbContextOptions<VehicleContext> options): base(options)
        {

        }

        public DbSet<Vehicle> Vehicle { get; set; }
    }
}
