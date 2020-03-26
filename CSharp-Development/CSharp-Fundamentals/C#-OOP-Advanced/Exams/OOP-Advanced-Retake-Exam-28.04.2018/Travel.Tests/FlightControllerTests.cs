// REMOVE any "using" statements, which start with "Travel." BEFORE SUBMITTING

using Travel.Core.Controllers;
using Travel.Entities;
using Travel.Entities.Factories;

namespace Travel.Tests
{
	using NUnit.Framework;

	[TestFixture]
    public class FlightControllerTests
    {
	    [Test]
	    public void TestController()
	    {
	        var airplaneFactory = new AirplaneFactory();
            

	        var trip = new Trip("Sofia", "London", airplaneFactory.CreateAirplane("LightAirplane"));
            var airport = new Airport();
	        airport.AddTrip(trip);
            var flightController = new FlightController(airport);

	        var result = flightController.TakeOff();
	        var expectedResult = "SofiaLondon1";

            Assert.AreEqual(result, expectedResult);
	    }
    }
}
