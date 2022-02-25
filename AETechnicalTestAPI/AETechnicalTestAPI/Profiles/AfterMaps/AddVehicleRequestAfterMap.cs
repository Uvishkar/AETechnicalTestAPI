using AETechnicalTestAPI.Domain_Models;
using DataModels = AETechnicalTestAPI.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AETechnicalTestAPI.Profiles.AfterMaps
{
    public class AddVehicleRequestAfterMap : IMappingAction<AddVehicleRequest, DataModels.Vehicle>
    {
        public void Process(AddVehicleRequest source, DataModels.Vehicle destination, ResolutionContext context)
        {
           
        }
    }
}




