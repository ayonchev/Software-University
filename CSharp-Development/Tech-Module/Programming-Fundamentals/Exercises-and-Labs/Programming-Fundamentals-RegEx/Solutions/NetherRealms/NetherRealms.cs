using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var participant in participants.OrderBy(x => x))
            {
                int health = 0;
                double damage = 0;

                string damagePattern = @"(\-?\d+\.?\d*)";
                foreach (Match number in Regex.Matches(participant, damagePattern))
                {
                    damage += Convert.ToDouble(number.Groups[1].Value);
                }

                for (int i = 0; i < participant.Length; i++)
                {
                    if (!Char.IsDigit(participant[i]) && participant[i] != '.' && participant[i] != '/' &&
                        participant[i] != '*' && participant[i] != '+' && participant[i] != '-')
                    {
                        health += (int)participant[i];
                    }
                    else if (participant[i] == '*')
                    {
                        damage *= 2;
                    }
                    else if (participant[i] == '/' && damage != 0)
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine($"{participant} - {health} health, {damage:F2} damage");
            }
        }
    }
}
