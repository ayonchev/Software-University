using System.Linq;

namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            ConstructorInfo ctor = typeof(BlackBoxInteger).GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { typeof(int) }, null);
            var instance = (BlackBoxInteger) ctor.Invoke(new object[] { 0 });

            ExecuteCommand(instance);
        }

        static void ExecuteCommand(BlackBoxInteger instance)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] commandData = input.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandData[0];
                int value = int.Parse(commandData[1]);
                MethodInfo currentMethod = null;

                switch (commandType)
                {
                    case "Add":
                        currentMethod = typeof(BlackBoxInteger).GetMethod("Add", BindingFlags.NonPublic | BindingFlags.Instance);
                        break;
                    case "Subtract":
                        currentMethod = typeof(BlackBoxInteger).GetMethod("Subtract", BindingFlags.NonPublic | BindingFlags.Instance);
                        break;
                    case "Multiply":
                        currentMethod = typeof(BlackBoxInteger).GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
                        break;
                    case "Divide":
                        currentMethod = typeof(BlackBoxInteger).GetMethod("Divide", BindingFlags.NonPublic | BindingFlags.Instance);
                        break;
                    case "RightShift":
                        currentMethod = typeof(BlackBoxInteger).GetMethod("RightShift", BindingFlags.NonPublic | BindingFlags.Instance);
                        break;
                    case "LeftShift":
                        currentMethod = typeof(BlackBoxInteger).GetMethod("LeftShift", BindingFlags.NonPublic | BindingFlags.Instance);
                        break;
                }

                currentMethod.Invoke(instance, new object[] { value });
                Console.WriteLine(typeof(BlackBoxInteger).GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(instance));
            }
        }
    }
}
