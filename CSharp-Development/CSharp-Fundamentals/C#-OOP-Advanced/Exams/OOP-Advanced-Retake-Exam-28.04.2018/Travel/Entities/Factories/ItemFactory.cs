using System;
using System.Linq;
using System.Reflection;

namespace Travel.Entities.Factories
{
	using Contracts;
	using Items;
	using Items.Contracts;

	public class ItemFactory : IItemFactory
	{
		public IItem CreateItem(string typeName)
		{
		    var currentType = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(t => t.Name == typeName);
		    var instance = (IItem) Activator.CreateInstance(currentType);

		    return instance;
		}
	}
}
