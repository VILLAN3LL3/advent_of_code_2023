﻿namespace Shared;

public class InputDataLoader
{
public static string[] LoadInputData(string fileName)
		{
			return File.ReadAllLines(Path.Combine(AppContext.BaseDirectory, fileName));
		}
}
