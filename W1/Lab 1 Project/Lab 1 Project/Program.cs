using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0;
            int secondNum = 0;
            string result = null;

            Console.WriteLine("Enter the first number:");
            result = Console.ReadLine();

            try
            {
                firstNum = int.Parse(result);
            }
            catch (FormatException ex){
                Console.WriteLine("Input a number.");
                return;
            }

            Console.WriteLine("Enter the second number:");
            result = Console.ReadLine();

            try
            {
                secondNum = int.Parse(result);
            }
            catch (FormatException ex){
                Console.WriteLine("Input a number.");
                return;
            }

            Console.WriteLine("Result:");
            Console.WriteLine(firstNum + secondNum);
        }
    }
}
