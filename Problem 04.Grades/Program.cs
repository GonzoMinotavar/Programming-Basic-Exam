using System;

namespace Grades
{
    public class Grades
    {
        public static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            double bestStudents = 0;
            double betterStudents = 0;
            double goodStudents = 0;
            double failStudents = 0;
            double average = 0;

            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                {
                    bestStudents++;
                }
                else if (grade >= 4 && grade < 5)
                {
                    betterStudents++;
                }
                else if (grade >= 3 && grade < 4)
                {
                    goodStudents++;
                }
                else
                {
                    failStudents++;
                }
                average += grade;
            }

            Console.WriteLine("Top students: {0:F2}%", bestStudents / students * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", betterStudents / students * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", goodStudents / students * 100);
            Console.WriteLine("Fail: {0:F2}%", failStudents / students * 100);
            Console.WriteLine("Average: {0:F2}", average / students);
        }
    }
}