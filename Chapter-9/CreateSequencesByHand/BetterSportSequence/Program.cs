namespace BetterSportSequence;

internal class Program
{
	static void Main(string[] args)
	{
		var sports = new BetterSportSequence();
		foreach (var sport in sports)
		{
			Console.WriteLine(sport);
		}

		Console.WriteLine(sports[3]);
	}
}
