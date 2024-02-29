using PersonalSoft.Domain.Entities;

namespace PersonalSoft.Infrastructure.Data
{
    public class SeedDb
    {
        private readonly PersonalSoftDbContext _context;

        #region Builder
        public SeedDb(PersonalSoftDbContext context)
        {
            _context = context;
        }

        public async Task ExecSeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();            
            await CheckLocationsSAsync();
            await CheckVehiclesAsync();
            await CheckLocationsXVehicleSAsync();            
        }

        private async Task CheckVehiclesAsync()
        {
            if (!_context.Vehicle.Any())
            {
                _context.Vehicle.AddRange(new List<Vehicle>
                {
                    new Vehicle
                    {
                        Plate = "ABC123"
                    },
                    new Vehicle
                    {
                        Plate = "DEF456"
                    },
                    new Vehicle
                    {
                        Plate = "GHI789"
                    },
                    new Vehicle
                    {
                        Plate = "JKL012"
                    }
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckLocationsSAsync()
        {
            if (!_context.Location.Any())
            {
                _context.Location.AddRange(new List<Location>
                {
                    new Location
                    {
                        Name = "PUNTO 1"
                    },
                    new Location
                    {
                        Name = "PUNTO 2"
                    },
                    new Location
                    {
                        Name = "PUNTO 3"
                    }
                });

                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckLocationsXVehicleSAsync()
        {
            if (!_context.LocationXVehicle.Any())
            {
                _context.LocationXVehicle.AddRange(new List<LocationXVehicle>
                {
                    new LocationXVehicle
                    {
                        VehicleId = 1,
                        LocationId = 1
                    },
                    new LocationXVehicle
                    {
                        VehicleId = 2,
                        LocationId = 2
                    },
                    new LocationXVehicle
                    {
                        VehicleId = 3,
                        LocationId = 3,
                        StartRental = DateTime.Now,
                        EndRental = DateTime.Now.AddDays(5)
                    },
                    new LocationXVehicle
                    {
                        VehicleId = 4,
                        LocationId = 3
                    }
                });

                await _context.SaveChangesAsync();
            }
        }

        #endregion
    }
}
