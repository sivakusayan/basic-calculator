using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{

    class Calculator
    {
        static void showErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Input. Shutting down application.");
            Console.ResetColor();

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            InputValidator reader = new InputValidator();
            int a;
            int b;

            try
            {
                Console.WriteLine("Please enter two integers.");
                a = reader.ReadInt();
                b = reader.ReadInt();
            } catch
            {
                showErrorMessage();
                System.Environment.Exit(1);
            }
        }
    }
}
