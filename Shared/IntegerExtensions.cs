using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared
{
    public static class IntegerExtensions
    {
        public static bool IsEven(this int number) {
            return number % 2 == 0;
        }
    }
}