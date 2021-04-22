using System;
using System.Collections.Generic;

namespace ConsoleApp_4_211_v3
{
    class Program
    {

        static void numberStudentWithGrade(List<int> studentG, int grade)
        {
            int count = 0;
            foreach (var item in studentG)
            {
                if (item == grade)
                {
                    count++;
                }
            }
            Console.WriteLine("number Student With Grade {0} Is: {1}",grade,count);
        }

        static void Main(string[] args)
        {
            string choice = "";
            string studentName = "";
            int studentGrade = 0;

            List<string> studentNames = new List<string>();
            List<int> studentGrades = new List<int>();

            while (true)
            {
                Console.WriteLine("Student Name:");
                studentName = Console.ReadLine();
                studentNames.Add(studentName);
                Console.WriteLine("Student Grade:");
                studentGrade = Convert.ToInt32(Console.ReadLine());
                studentGrades.Add(studentGrade);

                Console.WriteLine("Add Another Student ? (Yes/No)");
                choice = Console.ReadLine();
                if (choice == "No")
                    break;
            }
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Student Name: {0}, Student Grade: {1}" ,studentNames[i],studentGrades[i]);
            }
            Console.WriteLine("Enter the grade to search:");
            int a = Convert.ToInt32(Console.ReadLine());
            numberStudentWithGrade(studentGrades,a);
        }

    }
}
