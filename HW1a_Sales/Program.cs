// HW1a Sales Total

// Your Name: Jason Tran 
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double subtotal;
            double salestax;
            double total;

            const double taxrate = 0.085;

            string num1AsString;
            string num2AsString;



            Console.WriteLine("What is the product name of the item you are purchasing ?");
                 String ItemName = Console.ReadLine();
            Console.WriteLine("How many " + ItemName + " do you want to buy?");
                 num1AsString = Console.ReadLine();
            Console.WriteLine("What is the price for each " + ItemName + " ?");
                num2AsString = Console.ReadLine();

            num1 = Convert.ToDouble(num1AsString);
            num2 = Convert.ToDouble(num2AsString);

            subtotal = num1 * num2;
            salestax = subtotal * taxrate;
            total = subtotal + salestax;


            Console.WriteLine("Your subtotal for your bill is " + subtotal.ToString("C2"));
            Console.WriteLine("Your sales tax for your bill is " + salestax.ToString("C2"));
            Console.WriteLine("Your total for your bill is " + total.ToString("C2"));


                



        }
    }
}
