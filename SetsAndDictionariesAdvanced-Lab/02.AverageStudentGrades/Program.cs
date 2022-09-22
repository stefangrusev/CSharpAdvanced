using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            int students = int.Parse(Console.ReadLine());

            for (int i = 0; i < students; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<decimal>());
                }

                studentsGrades[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<decimal>> studentGrade in studentsGrades)
            {
                Console.Write($"{studentGrade.Key} -> ");

                foreach (decimal everyOneGrade in studentGrade.Value)
                {
                    Console.Write($"{everyOneGrade:F2} ");
                }

                Console.WriteLine($"(avg: {studentGrade.Value.Average():F2})");
            }
        }
    }
}
