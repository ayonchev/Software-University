namespace Travel.Entities
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Contracts;
	
	public class Airport : IAirport
	{
		private List<IBag> confiscatedBags;
		private List<IBag> checkedInBags;
		private List<ITrip> trips;
		private List<IPassenger> passengers;

	    public Airport()
	    {
	        this.confiscatedBags = new List<IBag>();
            this.checkedInBags = new List<IBag>();
            this.trips = new List<ITrip>();
            this.passengers = new List<IPassenger>();
	    }
	    public IReadOnlyCollection<IBag> CheckedInBags => this.checkedInBags;
	    public IReadOnlyCollection<IBag> ConfiscatedBags => this.confiscatedBags;
	    public IReadOnlyCollection<IPassenger> Passengers => this.passengers;
	    public IReadOnlyCollection<ITrip> Trips => this.trips;

        public IPassenger GetPassenger(string username) => passengers.FirstOrDefault(p => p.Username == username);

	    public ITrip GetTrip(string id) => trips.FirstOrDefault(t => t.Id == id);


	    public void AddPassenger(IPassenger passenger) => passengers.Add(passenger);

	    public void AddTrip(ITrip trip) => trips.Add(trip);

	    public void AddCheckedBag(IBag bag) => checkedInBags.Add(bag);

	    public void AddConfiscatedBag(IBag bag) => confiscatedBags.Add(bag);
	}
}