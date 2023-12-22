namespace Day_13
{
    public static class Mapper
    {
        public static List<List<string>> MapRows(IEnumerable<string> lines)
        {
            var result = new List<List<string>>();
            var list = new List<string>();
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    result.Add(list);
                    list = [];
                    continue;
                }
                list.Add(line);
            }
            result.Add(list);
            return result;
        }

        public static List<List<string>> MapColumns(IEnumerable<string> lines)
        {
            var result = new List<string>();
            var indexOffset = 0;
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {
                    result.Add(string.Empty);
                    indexOffset = result.Count;
                    continue;
                }

                for (int i = 0; i < line.Length; i++)
                {
                    if (result.Count <= i + indexOffset)
                    {
                        result.Add(line[i].ToString());
                    }
                    else
                    {
                        result[i + indexOffset] += line[i];
                    }
                }
            }
            return MapRows(result);
        }
    }
}