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

        static float a; // First input
        static float b; // Second input
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
                Console.WriteLine();
                showErrorMessage();
                exit();
            }
        }

        static void getMathOperator()
        {
            try
            {
                Console.WriteLine("Please enter a math operator.");
                mathOperator = reader.ReadBinaryMathOperator();
            }
            catch
            {
                Console.WriteLine();
                showErrorMessage();
                exit();
            }
        }

        static void calculate()
        {
            switch(mathOperator)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "/":
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }

        static void exit()
        {
            Console.WriteLine("---------------------------------------------------------------------------");
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
            Console.WriteLine();
            getMathOperator();
            Console.WriteLine();
            calculate();
            Console.WriteLine();
            exit();
        }
    }
}
