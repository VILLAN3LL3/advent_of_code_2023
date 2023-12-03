namespace No_1
{
	public static class InputLoader
	{
		public static string[] LoadInput()
		{
			return File.ReadAllLines(Path.Combine(AppContext.BaseDirectory, "InputData.txt"));
        }
	}
}

