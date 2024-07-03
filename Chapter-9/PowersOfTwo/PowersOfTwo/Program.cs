namespace PowersOfTwo;

internal class Program
{
	static void Main(string[] args)
	{
		var powers = new PowersOfTwo();
		foreach (var p in powers)
		{
			Console.WriteLine(p);
		}
	}
}
