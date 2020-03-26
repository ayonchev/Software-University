using System;
using System.Linq;
using System.Reflection;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var fields = typeof(Cat).GetFields(BindingFlags.Instance | BindingFlags.NonPublic).Where(f => typeof(string).IsAssignableFrom(f.FieldType)).ToArray();

        }
    }
}
