namespace No_1
{
	public static class InputLoader
	{
		public static string[] LoadInput(string fileName)
		{
			return File.ReadAllLines(Path.Combine(AppContext.BaseDirectory, fileName));
        }
	}
}

