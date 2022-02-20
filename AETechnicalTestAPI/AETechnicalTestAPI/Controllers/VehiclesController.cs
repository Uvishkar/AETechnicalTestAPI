using AETechnicalTestAPI.Domain_Models;
using AETechnicalTestAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AETechnicalTestAPI.Controllers
{
    [ApiController]
    public class VehiclesController : Controller
    {
        private readonly IVehiclesRepository vehicleRepository;

        public VehiclesController(IVehiclesRepository vehicleRepository)
        {
            this.vehicleRepository = vehicleRepository;

        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllVehiclesAsync()
        {
            var vehicles = await vehicleRepository.GetVehiclesAsync();

            var domainModelVehicles = new List<Vehicle>();

            foreach (var vehicle in vehicles)
            {
                domainModelVehicles.Add(new Vehicle()
                {
                    ID = vehicle.ID,
                    VehicleType = vehicle.VehicleType,
                    Make = vehicle.Make,
                    Model = vehicle.Model,
                    Year = vehicle.Year,
                    WheelCount = vehicle.WheelCount,
                    FuelType = vehicle.FuelType,
                    Active = vehicle.Active,
                    Tax = vehicle.Tax
                });

            }
            return Ok(domainModelVehicles);
        }
    }
}
