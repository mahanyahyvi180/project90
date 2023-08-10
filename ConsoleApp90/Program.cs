using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int gradeCounter = 1;

            while (gradeCounter <= 10)
            {
                Console.Write("Enter grade :");
                int grade = int.Parse(Console.ReadLine());
                total = total + grade;
                gradeCounter = gradeCounter + 1;
            }

            int average = total / 10;

            Console.WriteLine($"\nTotal of all 10 grades is{total}");
            Console.WriteLine($"Class average is{average}");
            Console.ReadLine();

        }
    }
}

