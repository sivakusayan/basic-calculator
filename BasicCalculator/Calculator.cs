using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{

    class Calculator
    {
        static InputValidator reader = new InputValidator();

        static int a; // First input
        static int b; // Second input
        static string mathOperator;

        static void showErrorMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Input.");
            Console.ResetColor();

            Console.ReadLine();
        }

        static void getNumberInputs()
        {
            try
            {
                Console.WriteLine("Please enter two integers.");
                a = reader.ReadInt();
                b = reader.ReadInt();
            }
            catch
            {
                showErrorMessage();
                exit();
            }
        }

        static void exit()
        {
            Console.WriteLine("Shutting down application.");
            System.Environment.Exit(1);
        }

        static void Main(string[] args)
        {
            getNumberInputs();
        }
    }
}
