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
        public string ReadMathOperator()
        {
            int input;
            bool isNumeric = int.TryParse(Console.ReadLine(), out input);

            if (!isNumeric) throw new System.Data.ConstraintException();

            return input;
        }
    }
}
