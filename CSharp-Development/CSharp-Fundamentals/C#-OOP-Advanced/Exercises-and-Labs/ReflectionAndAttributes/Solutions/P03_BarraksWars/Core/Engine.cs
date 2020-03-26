using P03_BarraksWars.Core.Commands;

namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private string InterpredCommand(string[] data, string commandName)
        {
            commandName = "P03_BarraksWars.Core.Commands." + commandName.ToUpper()[0] + commandName.Substring(1, commandName.Length - 1).ToLower();

            var commandType = Type.GetType(commandName);
            var instance = (Command)Activator.CreateInstance(commandType, new object[] { data, repository, unitFactory });
            string result = instance.Execute();

            return result;
        }
    }
}
