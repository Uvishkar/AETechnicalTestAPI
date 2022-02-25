using AETechnicalTestAPI.Domain_Models;
using DataModels = AETechnicalTestAPI.Models;
using AETechnicalTestAPI.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace AETechnicalTestAPI.Controllers
{
    [ApiController]
    public class VehiclesController : Controller
    {
        private readonly IVehiclesRepository vehicleRepository;
        private readonly IMapper mapper;
        public VehiclesController(IVehiclesRepository vehicleRepository,IMapper mapper)
        {
            this.vehicleRepository = vehicleRepository;
            this.mapper = mapper;
            CsvLoader.CSVDataloader();

        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllVehiclesAsync()
        {
            var vehicles = await vehicleRepository.GetVehiclesAsync();

           
            return Ok(mapper.Map<List<Vehicle>>(vehicles));
        }

        [HttpGet]
        [Route("[controller]/{ID}"), ActionName("GetVehicleAsync")]
        public async Task<IActionResult> GetVehicleAsync([FromRoute] int ID)
        {
            // Fetch Student Details
            var vehicle = await vehicleRepository.GetVehicleAsync(ID);

            // Return Student
            if (vehicle == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<Vehicle>(vehicle));
        }
        [HttpPut]
        [Route("[controller]/{ID}")]
        public async Task<IActionResult> UpdateVehicleAsync([FromRoute] int ID, [FromBody] UpdateVehicleRequest request)
        {
            if (await vehicleRepository.Exists(ID))
            {
                // Update Details
                var updatedVehicle = await vehicleRepository.UpdateVehicle(ID, mapper.Map<Vehicle>(request));

                if (updatedVehicle != null)
                {
                    return Ok(mapper.Map<Vehicle>(updatedVehicle));
                }
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[controller]/{ID}")]
        public async Task<IActionResult> DeleteVehicleAsync([FromRoute] int ID)
        {
            if (await vehicleRepository.Exists(ID))
            {
                var vehicle = await vehicleRepository.DeleteVehicle(ID);
                return Ok(mapper.Map<Vehicle>(vehicle));
            }

            return NotFound();
        }
            
        [HttpPost]
        [Route("[controller]/add")]
        public async Task<IActionResult> AddVehicleAsync([FromBody] AddVehicleRequest request)
        {
            var vehicle = await vehicleRepository.AddVehicle(mapper.Map<DataModels.Vehicle>(request));
            return CreatedAtAction(nameof(GetVehicleAsync),new {ID = vehicle.ID},
                mapper.Map<Vehicle>(vehicle));
        }

    }
}
