namespace Day_12
{
    public class SpringGroup
    {
        public SpringGroup(string springs, params int[] damagedSpringCounts)
        {
            Springs = springs;
            DamagedSpringCounts.AddRange(damagedSpringCounts);
        }
        public string Springs { get; set; }
        public List<int> DamagedSpringCounts { get; set; } = [];
        public string Key => $"{Springs},{string.Join(',', DamagedSpringCounts)}";
    }
}