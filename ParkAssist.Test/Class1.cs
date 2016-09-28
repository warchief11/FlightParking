using NUnit.Framework;
using ParkAssist.Models;

namespace ParkAssist.Test
{
    [TestFixture]
    public class TestFlightManager
    {
        private IRepository _repo;

        [OneTimeSetUp]
        public void Setup()
        {
            _repo = new Repository();
        }

        [Test]
        public void GetReservationByGateID()
        {
            //arrange
            var flightManager = new FlightManager(_repo);
            //act
            var reservations = flightManager.GetReservations(2);

            //assert
            Assert.IsTrue(reservations.Count > 0);
        }
    }
}
