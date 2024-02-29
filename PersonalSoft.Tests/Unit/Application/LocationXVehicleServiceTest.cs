using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PersonalSoft.Application.IRepositories;
using PersonalSoft.Application.Services;
using PersonalSoft.Domain.Entities;

namespace PersonalSoft.Tests.Unit.Application
{
    [TestClass]
    public class LocationXVehicleServiceTest
    {
        private MockRepository? _mockRepository;
        private Mock<IUnitOfWork>? _mockUnitOfWork;
        private Mock<IGenericRepository<LocationXVehicle>>? _mockLocationXVehicleRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockRepository = new MockRepository(MockBehavior.Loose);
            _mockUnitOfWork= _mockRepository.Create<IUnitOfWork>();
            _mockLocationXVehicleRepository = _mockRepository.Create<IGenericRepository<LocationXVehicle>>();
        }

        private LocationXVehicleService CreateService()
        {
            return new LocationXVehicleService(_mockUnitOfWork!.Object, _mockLocationXVehicleRepository!.Object);
        }

        [TestMethod]
        public void GetAllLocationXVehicle_Return_Data()
        {
            _mockLocationXVehicleRepository!.Setup(x => x.GetAll()).Returns(GetMockLocationXVehicle().AsQueryable());
            var service = CreateService();

            var result = service.GetAllLocationXVehicle(1);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
        }

        private static List<LocationXVehicle> GetMockLocationXVehicle() 
        {
            return new List<LocationXVehicle> {
                   new LocationXVehicle
                   {
                        Id = 1,
                        LocationId = 1,
                        VehicleId = 1
                   },
                   new LocationXVehicle {
                       Id = 2,
                       LocationId = 2,
                       VehicleId = 2
                   }
               };
        }
    }
}
