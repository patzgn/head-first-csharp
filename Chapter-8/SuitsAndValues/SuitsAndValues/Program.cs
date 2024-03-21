namespace SuitsAndValues;

internal class Program
{
	private static readonly Random random = new();

	static void Main(string[] args)
	{
		Card card = new((Values)random.Next(1, 14), (Suits)random.Next(4));
		Console.WriteLine(card.Name);
	}
}
