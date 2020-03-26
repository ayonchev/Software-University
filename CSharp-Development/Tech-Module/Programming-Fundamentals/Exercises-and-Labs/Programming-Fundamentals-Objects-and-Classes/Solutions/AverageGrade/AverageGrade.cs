using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrade
{
    public class AverageGrade
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> allStudents = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] inputArray = Console.ReadLine().Split(' ');
                string name = inputArray[0];
                double[] grades = new double[inputArray.Length - 1];

                for (int k = 1; k < inputArray.Length; k++)
                {
                    grades[k - 1] = double.Parse(inputArray[k]);
                }

                Student currentStudent = new Student()
                {
                    Name = name,
                    Grades = grades
                };
                
                if (currentStudent.AverageGrade >= 5.00)
                {
                    allStudents.Add(currentStudent);
                }
            }

            var result = allStudents.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} -> {person.AverageGrade:F2}");
            }
        }
    }
}
