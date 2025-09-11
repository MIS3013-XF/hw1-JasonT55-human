// HW1b Grade

// Your Name: Jason Tran 
// Did you seek help ? If yes, specify the helper or web link here: chatgpt, reason: to find the formula to calculate the final grade based on the weight  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            double num4;
            double num5;
            double FinalGrade;

            string assignments;
            string exam1;
            string exam2;
            string exam3;
            string participations;


            Console.WriteLine("What is your first name?");
            string FName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string LName = Console.ReadLine();
            Console.WriteLine("What is your student id?");
            string id = Console.ReadLine();


            Console.WriteLine("What is your overall percentage grade for assignments?");
            assignments = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for Exam 1?");
            exam1 = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for Exam 2?");
            exam2 = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for Exam 3?");
            exam3 = Console.ReadLine();
            Console.WriteLine("What is your overall percentage grade for participations?");
            participations = Console.ReadLine();


            num1 = Convert.ToDouble(assignments);
            num2 = Convert.ToDouble(exam1);
            num3 = Convert.ToDouble(exam2);
            num4 = Convert.ToDouble(exam3);
            num5 = Convert.ToDouble(participations);

            FinalGrade = ((num1 * .2) + (num2 * .15) + (num3 * .25) + (num4 * .25) + (num5 * .15)) / 100;


            Console.WriteLine(FName + (" ") + LName + " (" + id + "), " + "your final grade is " + FinalGrade.ToString("P2"));









        }
    }
}
