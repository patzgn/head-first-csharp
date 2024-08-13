﻿using System.Text;

namespace UseAMemoryStream;

internal class Program
{
	static void Main(string[] args)
	{
		using (var ms = new MemoryStream())
		{
			using (var sw = new StreamWriter(ms))
			{
				sw.WriteLine("The value is {0:0.00}", 123.45678);
			}
			Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
		}
	}
}
