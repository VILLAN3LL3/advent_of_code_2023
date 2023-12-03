using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace No_1
{
    public static partial class NumberExtractor
    {
        private static IReadOnlyDictionary<string, string> SpelledNumbers = new Dictionary<string, string> {
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" }, 
            { "six", "6" }, 
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" }
        };

        [GeneratedRegex(@"[^\d]")]
        private static partial Regex NoDigitsRegex();
        
        public static string ExtractAllNumbersFromString(string input) {
            var stringToCheck = input;
            var resultStringBuilder = new StringBuilder();
            string? nextNumber;
            while (!string.IsNullOrWhiteSpace(stringToCheck))
            {
                nextNumber = ExtractNextNumber(stringToCheck);
                if(nextNumber is not null) {
                    resultStringBuilder.Append(nextNumber);
                }
                stringToCheck = stringToCheck[1..];
            }
            return resultStringBuilder.ToString();
        }

        private static string? ExtractNextNumber(string stringToCheck) {
            string firstCharAsString = stringToCheck[0].ToString();
            if (int.TryParse(firstCharAsString, out int _)) {
                return firstCharAsString;
            } 
            foreach (var key in SpelledNumbers.Keys)
            {
                if(stringToCheck.StartsWith(key)) {
                    return SpelledNumbers[key];
                }
            }
            return null;
        }
    }
}