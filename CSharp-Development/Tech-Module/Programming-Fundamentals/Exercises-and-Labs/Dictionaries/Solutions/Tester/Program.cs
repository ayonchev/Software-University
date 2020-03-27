using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, Dictionary<string, int>> resultDict = new Dictionary<string, Dictionary<string, int>>();

            //resultDict.Add("Gosho", new Dictionary<string, int>());
            //resultDict["Gosho"].Add("Stamatov", 2);
            //resultDict.Add("Pesho", new Dictionary<string, int>());
            //resultDict["Pesho"].Add("Penchev", 2);
            //resultDict["Gosho"].Add("Krasimirov", 3);
            //resultDict["Gosho"]["Krasimirov"]++;

            //Console.WriteLine(string.Join(", ", resultDict["Gosho"].Keys));

            Dictionary<string, int> resultDict = new Dictionary<string, int>();
            resultDict["Gosho"] = 1;
            resultDict["Pesho"] = 2;
            var avg = resultDict.Values.Average();
            Console.WriteLine(avg);
            //foreach (var person in resultDict)
            //{
            //    string firstName = person.Key;
            //    Dictionary<string, int> otherDetails = person.Value;

            //    Console.WriteLine(firstName + " ");
            //    foreach (var details in otherDetails)
            //    {
            //        string lastName = details.Key;
            //        int visits = details.Value;
            //        Console.WriteLine(lastName + " " + visits);
            //    }
            //}
        }
    }
}
