using PersonalSoft.Application.Base;
using PersonalSoft.Domain.Entities;

namespace PersonalSoft.Application.IServices
{
    public interface ILocationXVehicleService : IEntityService<LocationXVehicle>
    {
        IQueryable<LocationXVehicle> GetAllLocationXVehicle(int locationId);
    }
}
