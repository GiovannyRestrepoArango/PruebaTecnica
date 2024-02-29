using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalSoft.Application.IServices;
using PersonalSoft.Domain.DTOs;

namespace PersonalSoft.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationXVehicleController : ControllerBase
    {
        private readonly ILocationXVehicleService _locationXVehicleService;
        private readonly ILogger<LocationXVehicleController> _logger;
        private readonly IMapper _mapper;
        
        public LocationXVehicleController(ILocationXVehicleService locationXVehicleService, ILogger<LocationXVehicleController> logger, IMapper mapper)
        {

            _locationXVehicleService = locationXVehicleService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllLocationXVehicle(int locationId)
        {
            var vehiclesList = _locationXVehicleService.GetAllLocationXVehicle(locationId);
            var vehiclesListDto = _mapper.Map<IEnumerable<LocationXVehicleDto>>(vehiclesList);
            return Ok(vehiclesListDto);
        }
    }
}
