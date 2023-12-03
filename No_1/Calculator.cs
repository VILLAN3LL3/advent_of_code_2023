using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace No_1
{
    public class Calculator
    {
        public int Calculate(string[] input) {
            var result = 0;
            foreach (var item in input)
            {
                result = result + CalculateSingle(item);
            }
            return result;
        }

        public int CalculateSingle(string input) {
            Regex regex = new Regex(@"[^\d]");
            var numbersOnly = regex.Replace(input, "");
            var first = numbersOnly[0];
            var last = numbersOnly[numbersOnly.Count() - 1];
            var resultAsString = $"{first}{last}";
            return int.Parse(resultAsString);
        }
    }
}