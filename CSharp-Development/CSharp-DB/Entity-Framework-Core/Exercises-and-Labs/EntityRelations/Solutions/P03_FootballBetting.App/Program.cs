using P03_FootballBetting.Data;
using System;
using System.Linq;

namespace P03_FootballBetting.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new FootballBettingContext())
            {
                context.Database.EnsureCreated();
            }
        }
    }
}
