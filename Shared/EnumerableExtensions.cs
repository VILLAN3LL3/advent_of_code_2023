using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared
{
    public static class EnumerableExtensions
    {
        public static int Multiply(this IEnumerable<int> numbers) => numbers.Aggregate((a, b) => a * b);
    }
}