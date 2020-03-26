using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
            string name;
            string phoneNumber;

            while (true)
            {
                string[] instructions = Console.ReadLine().Split(' ').ToArray();
                string command = instructions[0];

                if (command == "END")
                {
                    break;
                }
                else if (command == "S")
                {
                    name = instructions[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine(name + " -> " + phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                else if (command == "A")
                {
                    name = instructions[1];
                    phoneNumber = instructions[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phoneNumber;
                    }
                    else
                    {
                        phonebook.Add(name, phoneNumber);
                    }
                }
                else if (command == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine(contact.Key + " -> " + contact.Value);
                    }
                }
            }
        }
    }
}
