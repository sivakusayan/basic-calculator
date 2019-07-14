using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
            Console.Write("Shutting down application.");
            for (int i = 0; i < 2; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            Thread.Sleep(500);
            System.Environment.Exit(1);
        }

        static void Main(string[] args)
        {
            getNumberInputs();
        }
    }
}
