using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class MathOperations
    {
        // Method that doubles the input number
        public int DoubleNumber(int number)
        {
            return number * 2;
        }

        // Method that squares the input number
        public int SquareNumber(int number)
        {
            return number * number;
        }

        // Method that calculates the factorial of the input number
        public int FactorialNumber(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }

}
