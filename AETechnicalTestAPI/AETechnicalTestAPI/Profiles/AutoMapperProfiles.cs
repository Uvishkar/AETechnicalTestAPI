using AutoMapper;
using AETechnicalTestAPI.Domain_Models;
using DataModels = AETechnicalTestAPI.Models;
using AETechnicalTestAPI.Profiles.AfterMaps;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Vehicle, Vehicle>()
                .ReverseMap();
            CreateMap<UpdateVehicleRequest, DataModels.Vehicle>()
                .AfterMap<UpdateVehicleRequestAfterMap>();

            CreateMap<AddVehicleRequest, DataModels.Vehicle>()
                .AfterMap<AddVehicleRequestAfterMap>();
        }
    }
}
