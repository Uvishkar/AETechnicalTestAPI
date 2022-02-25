using AETechnicalTestAPI.Domain_Models;
using AutoMapper;
using DataModels = AETechnicalTestAPI.Models;
namespace AETechnicalTestAPI.Profiles.AfterMaps
{
    public class UpdateVehicleRequestAfterMap : IMappingAction<UpdateVehicleRequest, DataModels.Vehicle>
    {
        public void Process(UpdateVehicleRequest source, DataModels.Vehicle destination, ResolutionContext context)
        {
        //    destination.Address = new DataModels.Address()
        //    {
        //        PhysicalAddress = source.PhysicalAddress,
        //        PostalAddress = source.PostalAddress
        //    };
        }
    }
}
