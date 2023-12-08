namespace Day_5
{
    public class CategoryMap
    {
        public int SortOrder { get; set; }

        public string CategoryName { get; set; } = "";

        public List<CategoryRange> Ranges { get; set; } = [];
    }
}