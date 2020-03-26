using System;
using System.Reflection;

namespace Travel.Core
{
    using System.Linq;
    using Contracts;
    using Controllers.Contracts;
    using IO.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IAirportController airportController;
        private readonly IFlightController flightController;

        public Engine(IReader reader, IWriter writer, IAirportController airportController,
            IFlightController flightController)
        {
            this.reader = reader;
            this.writer = writer;
            this.airportController = airportController;
            this.flightController = flightController;
        }

        public void Run()
        {
            while (true)
            {
                var input = this.reader.ReadLine();

                if (input == "END")
                {
                    break;
                }

                try
                {
                    var result = this.ProcessCommand(input);
                    writer.WriteLine(result);
                }
                catch (System.InvalidOperationException ex)
                {
                    writer.WriteLine("ERROR: " + ex.Message);
                }
            }
        }

        public string ProcessCommand(string input)
        {
            var tokens = input.Split(' ');

            var commandName = tokens.First();
            var args = tokens.Skip(1).ToArray();

            //var currentCommand = airportController.GetType()
            //    .GetMethods()
            //    .FirstOrDefault(m => m.Name == commandName);

            //string result;


            //try
            //{
            //    if (currentCommand != null)
            //    {
            //        result = (string)currentCommand.Invoke(airportController, args);

            //    }
            //    else
            //    {
            //        currentCommand = flightController.GetType()
            //            .GetMethods()
            //            .FirstOrDefault(m => m.Name == commandName);
            //        result = (string)currentCommand.Invoke(flightController, args);
            //    }
            //}
            //catch (Exception e)
            //{
            //    return e.Message;
            //}
            

            //return result;
            string output = string.Empty;

            switch (commandName)
            {
                case "RegisterPassenger":
                    {
                        var username = args[0];
                        output = this.airportController.RegisterPassenger(username);
                        break;
                    }
                case "RegisterTrip":
                    {
                        var source = args[0];
                        var destination = args[1];
                        var planeType = args[2];

                        output = this.airportController.RegisterTrip(source, destination, planeType);
                        break;
                    }
                case "RegisterBag":
                    {
                        var username = args[0];
                        var bagItems = args.Skip(1);

                        output = this.airportController.RegisterBag(username, bagItems);
                        break;
                    }
                case "CheckIn":
                    {
                        var username = args[0];
                        var tripId = args[1];
                        var bagCheckInIndices = args.Skip(2).Select(int.Parse);

                        output = this.airportController.CheckIn(username, tripId, bagCheckInIndices);
                        break;
                    }
                case "TakeOff":
                    {
                        output = this.flightController.TakeOff();
                        break;
                    }
            }

            return output;
        }
    }
}