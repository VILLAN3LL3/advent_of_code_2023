using Shared;

namespace Day_3
{
    public static class GearRatioCalculator
    {
        public static int CalculateGearRatioSum(EngineSchematic engineSchematic, List<PartNumber> partNumbers) {
            
            var gearRatios = new List<int>();

            for (int i = 0; i < engineSchematic.GearCount; i++)
            {
                IEnumerable<PartNumber> numbersWithGear = partNumbers.Where(pn => pn.AdjacentGearIds.Contains(i));
                if(numbersWithGear.Count() > 1) {
                    gearRatios.Add(numbersWithGear.Select(number => number.Value).Multiply());
                }
            }

            return gearRatios.Sum();
        }
    }
}