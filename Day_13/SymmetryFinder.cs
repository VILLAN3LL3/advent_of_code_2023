
namespace Day_13
{
    public static class SymmetryFinder
    {
        public static int FindSymmetry(List<string> lines)
        {
            var result = 0;

            for (int i = 0; i < lines.Count - 1; i++)
            {
                var currentLine = lines[i];
                var nextLine = lines[i + 1];

                if (!nextLine.Equals(currentLine))
                {
                    continue;
                }

                if (IsMirrorImpossible(lines, i))
                {
                    continue;
                }

                result = i + 1;
            }   

            return result;
        }

        private static bool IsMirrorImpossible(List<string> lines, int index)
        {
            var currentIndex = index;
            var nextIndex = index + 1;

            while (true)
            {

                currentIndex--;
                nextIndex++;

                if (currentIndex < 0 || nextIndex == lines.Count)
                { 
                    return false; 
                }

                if (lines[currentIndex] != lines[nextIndex])
                { 
                    return true; 
                }
            }
        }
    }
}
