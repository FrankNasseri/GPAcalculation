using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAcalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate GPA on 4.0 scale
            Console.WriteLine("What is your GPA");
            // How many of each grade was earned
            Console.WriteLine("How many of each grade was earned?");
            //A = 4 points
            Console.WriteLine("How many As");
            double gradeA = double.Parse(Console.ReadLine());
            //B = 3 points
            Console.WriteLine("How many Bs");
            double gradeB = double.Parse(Console.ReadLine());
            //C = 2 points
            Console.WriteLine("How many Cs");
            double gradeC = double.Parse(Console.ReadLine());
            //D = 1 point
            Console.WriteLine("How many Ds");
            double gradeD = double.Parse(Console.ReadLine());
            //F = 0 points
            Console.WriteLine("How many Fs");
            double gradeF = double.Parse(Console.ReadLine());

            double totalGpa = ((gradeA * 4) + (gradeB * 3) + (gradeC * 2) + (gradeD * 1) + (gradeF * 0));
            double totalGrades = (gradeA + gradeB + gradeC + gradeD + gradeF);
            double myGpa = (totalGpa / totalGrades);

            Console.WriteLine("Your GPA:" + myGpa);
        }
    }
}
