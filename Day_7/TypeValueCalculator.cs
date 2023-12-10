using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_7
{
    public static class TypeValueCalculator
    {
        public static int CalculateTypeValue(Hand hand)
        {
            return CalculateValueFromFrequency(CountCardValueFrequency(hand));
        }

        private static int CalculateValueFromFrequency(List<int> frequency)
        {
            return int.Parse(string.Join("", frequency).PadRight(5, '0'));
        }

        private static List<int> CountCardValueFrequency(Hand x)
        {
            return x.Cards.GroupBy(x => x).OrderByDescending(x => x.Count()).Select(x => x.Count()).ToList();
        }
    }
}