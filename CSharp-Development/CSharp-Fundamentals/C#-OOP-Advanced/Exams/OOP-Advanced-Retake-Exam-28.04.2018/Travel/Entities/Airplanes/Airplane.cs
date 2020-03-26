using Travel.Entities.Airplanes.Contracts;

namespace Travel.Entities.Airplanes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities.Contracts;

    // migrated from java. please do the needful kind sir
    public abstract class Airplane : IAirplane
    {
        private readonly List<IBag> baggageCompartment;
        private readonly List<IPassenger> passengers;
        protected Airplane(int countSeats, int countBags)
        {
            this.Seats = countSeats;
            this.BaggageCompartments = countBags;

            this.baggageCompartment = new List<IBag>();
            this.passengers = new List<IPassenger>();
        }

        public int Seats { get; }
        public int BaggageCompartments { get; }
        public bool IsOverbooked => this.passengers.Count > Seats;


        public IReadOnlyCollection<IBag> BaggageCompartment => baggageCompartment;
        public IReadOnlyCollection<IPassenger> Passengers => passengers;

        public void AddPassenger(IPassenger passenger)
        {
            this.passengers.Add(passenger);
        }

        public IPassenger RemovePassenger(int seat)
        {
            var passenger = passengers[seat];
            passengers.RemoveAt(seat);

            return passenger;
        }

        public IEnumerable<IBag> EjectPassengerBags(IPassenger passenger)
        {
            var removedBaggage = baggageCompartment.Where(b => b.Owner == passenger).ToList();
            baggageCompartment.RemoveAll(b => b.Owner == passenger);

            return removedBaggage;
        }

        public void LoadBag(IBag bag)
        {
            if (BaggageCompartments < baggageCompartment.Count + 1)
                throw new InvalidOperationException($"No more bag room in {this.GetType().Name}!");

            this.baggageCompartment.Add(bag);
        }

        //public IEnumerable<IBag> Out(IPassenger passenger)
        //{
        //    var passengerBags = this.bagazhi
        //        .Where(b => b.Owner == passenger)
        //        .ToArray();

        //    foreach (var bag in passengerBags)
        //        this.bagazhi.Remove(bag);

        //    return passengerBags;
        //}

        //public void LoadBag(IBag bag)
        //{
        //    var isBaggageCompartmentFull = this.BaggageCompartment.Count > this.BaggageCompartments;
        //    if (isBaggageCompartmentFull)
        //        throw new InvalidOperationException($"No more bag room in {this.GetType().ToString()}!");

        //    this.bagazhi.Add(bag);
        //}

    }
}