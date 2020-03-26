using System;
using System.Linq;
using System.Reflection;

namespace Travel.Entities.Factories
{
	using Contracts;
	using Airplanes.Contracts;

	public class AirplaneFactory : IAirplaneFactory
	{
		public IAirplane CreateAirplane(string typeName)
		{
		    var currentType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(t => t.Name == typeName);
		    var instance = (IAirplane) Activator.CreateInstance(currentType);

		    return instance;
		}
	}
}