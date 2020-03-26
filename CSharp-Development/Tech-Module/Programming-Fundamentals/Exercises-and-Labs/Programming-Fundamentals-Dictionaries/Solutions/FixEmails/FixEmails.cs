using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            var resultDict = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    break;
                }
                else
                {
                    string email = Console.ReadLine();
                    var checkEmail = email.Reverse().Take(2);
                    checkEmail = string.Join("", checkEmail);
                    if ((string)checkEmail != "su" && (string)checkEmail != "ku")
                    {
                        resultDict[input] = email;
                    }
                }
            }

            foreach (var person in resultDict)
            {
                Console.WriteLine(person.Key + " -> " + person.Value);
            }
        }
    }
}
