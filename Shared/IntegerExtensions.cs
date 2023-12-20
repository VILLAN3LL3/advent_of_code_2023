using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared
{
    public static class IntegerExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static int Faculty(this int number)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(number);

            int faculty = 1;

            if (number == 0 || number == 1)
                faculty = 1;
            else
            {
                for (int i = 1; i <= number; i++)
                    faculty *= i;
            }

            return faculty;

        }
    }
}