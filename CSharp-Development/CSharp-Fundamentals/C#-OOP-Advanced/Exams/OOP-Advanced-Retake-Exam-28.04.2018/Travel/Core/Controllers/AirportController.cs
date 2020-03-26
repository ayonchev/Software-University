namespace Travel.Core.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Contracts;
	using Entities;
	using Entities.Contracts;
	using Entities.Factories;
	using Entities.Factories.Contracts;

	public class AirportController : IAirportController
	{
        private const int BagValueConfiscationThreshold = 3000;

        private IAirport airport;

        private readonly IAirplaneFactory airplaneFactory;
        private readonly IItemFactory itemFactory;

        public AirportController(IAirport airport)
        {
            this.airport = airport;
            this.airplaneFactory = new AirplaneFactory();
            this.itemFactory = new ItemFactory();
        }

        public string RegisterPassenger(string username)
        {
            if (this.airport.Passengers.Any(p => p.Username == username))
                throw new InvalidOperationException($"Passenger {username} already registered!");

            var passenger = new Passenger(username);

            this.airport.AddPassenger(passenger);

            return $"Registered {passenger.Username}";
        }

	    public string RegisterTrip(string source, string destination, string planeType)
	    {
	        var airplane = airplaneFactory.CreateAirplane(planeType);

	        var trip = new Trip(source, destination, airplane);

	        airport.AddTrip(trip);

	        return $"Registered trip {trip.Id}";
	    }

        public string RegisterBag(string username, IEnumerable<string> bagItems)
        {
            var passenger = this.airport.GetPassenger(username);

            var items = bagItems.Select(itemType => itemFactory.CreateItem(itemType)).ToArray();
            var bag = new Bag(passenger, items);

            passenger.Bags.Add(bag);

            return $"Registered bag with {string.Join(", ", bagItems)} for {username}";
        }

        public string CheckIn(string username, string tripId, IEnumerable<int> bagsIndicesToCheckIn)
        {
            var passenger = this.airport.GetPassenger(username);
            var trip = airport.Trips.FirstOrDefault(t => t.Id == tripId);

            var passengers = airport.Trips.SelectMany(t => t.Airplane.Passengers);
            var checkedIn = passengers.Any(p => p.Username == username);
            if (checkedIn)
                throw new InvalidOperationException($"{username} is already checked in!");

            var confiscatedBags = CheckInBags(passenger, bagsIndicesToCheckIn);
            trip.Airplane.AddPassenger(passenger);

            return
                $"Checked in {passenger.Username} with {bagsIndicesToCheckIn.Count() - confiscatedBags}/{bagsIndicesToCheckIn.Count()} checked in bags";
        }

        private int CheckInBags(IPassenger passenger, IEnumerable<int> bagsIndicesToCheckIn)
        {
            var bags = passenger.Bags;

            var confiscatedBagsCount = 0;
            foreach (var bagIndex in bagsIndicesToCheckIn)
            {
                var currentBag = bags[bagIndex];
                bags.RemoveAt(bagIndex);

                if (ShouldConfiscate(currentBag))
                {
                    airport.AddConfiscatedBag(currentBag);
                    confiscatedBagsCount++;
                }
                else
                {
                    airport.AddCheckedBag(currentBag);
                }
            }

            return confiscatedBagsCount;
        }

        private static bool ShouldConfiscate(IBag bag)
        {
            var luggageValue = bag.Items.ToArray().Sum(i => i.Value);

            var shouldConfiscate = luggageValue > BagValueConfiscationThreshold;
            return shouldConfiscate;
        }
    }
}