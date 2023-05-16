using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");

            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /):");
            char op = char.Parse(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            Console.WriteLine("The result is: " + result);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
