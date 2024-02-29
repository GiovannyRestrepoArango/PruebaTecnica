using Microsoft.EntityFrameworkCore;
using PersonalSoft.Application.Base;
using PersonalSoft.Application.IRepositories;
using PersonalSoft.Application.IServices;
using PersonalSoft.Domain.Entities;

namespace PersonalSoft.Application.Services
{
    public class LocationXVehicleService : EntityService<LocationXVehicle>, ILocationXVehicleService
    {
        public LocationXVehicleService(IUnitOfWork unitOfWork, IGenericRepository<LocationXVehicle> repository)
            : base(unitOfWork, repository)
        {

        }

        public IQueryable<LocationXVehicle> GetAllLocationXVehicle(int locationId)
        {
            return GetAll().Include(x => x.Vehicle).Include(x => x.Location).Where(x => x.LocationId == locationId && x.StartRental == null && x.EndRental == null);
        }
    }
}
