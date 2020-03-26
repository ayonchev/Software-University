using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloatingNumbers
{
    class ComparingFloatingNumbers
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            bool areEqual = false;

            double eps = 0.000001;

            double difference = Math.Abs(firstNum - secondNum);

            if (difference < eps)
            {
                areEqual = true;
            }
            else if (difference > eps)
            {
                areEqual = false;
            }
            else if (difference == eps)
            {
                areEqual = false;
            }

            Console.WriteLine(areEqual);
        }
    }
}
