using System;
using System.Net;
using System.IO;

namespace No_1
{
	public class InputLoader
	{
		public string[] LoadInput()
		{
			return File.ReadAllLines(Path.Combine(AppContext.BaseDirectory, "InputData.txt"));
        }
	}
}

