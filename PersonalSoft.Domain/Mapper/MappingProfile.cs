using PersonalSoft.Domain.Entities;
using PersonalSoft.Domain.DTOs;
namespace PersonalSoft.Domain.Mapper
{
    public class MappingProfile: AutoMapper.Profile
    {
        public MappingProfile() 
        {            
            CreateMap<LocationXVehicle, LocationXVehicleDto>()
                .ForMember(x => x.LocationName, opt => opt.MapFrom(src => src.Location.Name))
                .ForMember(x => x.VehiclePlate, opt => opt.MapFrom(src => src.Vehicle.Plate))
                .ReverseMap();
        }
    }
}
