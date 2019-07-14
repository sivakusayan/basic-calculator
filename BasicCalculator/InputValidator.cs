using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class InputValidator
    {
        /**
         * Reads an integer from user input. Throws a Data.ConstraintException if
         * the input cannot be parsed.
         **/ 
        public int ReadInt()
        {
            int input;
            bool isNumeric = int.TryParse(Console.ReadLine(), out input);

            if (!isNumeric) throw new System.Data.ConstraintException();

            return input;
        }

        /**
         * Reads a binary math operator from user input.
         **/ 
        public string ReadBinaryMathOperator()
        {
            string input = Console.ReadLine();
            if (input.Equals("+") || input.ToLower().Equals("add")) return "+";
            if (input.Equals("-") || input.ToLower().Equals("minus")) return "-";
            if (input.Equals("*") || input.ToLower().Equals("multiply")) return "*";
            if (input.Equals("/") || input.ToLower().Equals("divide")) return "/";

            throw new System.Data.ConstraintException();
        }
    }
}
