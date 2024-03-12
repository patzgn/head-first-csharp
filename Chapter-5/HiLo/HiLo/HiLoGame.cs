namespace HiLo;

internal static class HiLoGame
{
	public const int MAXIMUM = 10;

	private static Random random = new();
	private static int currentNumber = random.Next(1, MAXIMUM + 1);
	private static int nextNumber = random.Next(1, MAXIMUM + 1);
	private static int pot = 10;

	public static int GetPot() => pot;

	public static void Guess(bool higher)
	{
		if ((higher && nextNumber >= currentNumber) || (!higher && nextNumber <= currentNumber))
		{
			Console.WriteLine("You guessed right!");
			pot++;
		}
		else
		{
			Console.WriteLine("Bad luck, you guessed wrong.");
			pot--;
		}
		currentNumber = nextNumber;
		nextNumber = random.Next(1, MAXIMUM + 1);
		Console.WriteLine($"The current number is {currentNumber}");
	}

	public static void Hint()
	{
		int half = MAXIMUM / 2;
		if (nextNumber >= half)
			Console.WriteLine($"The current number is {currentNumber}, the next number is at least {half}");
		else Console.WriteLine($"The current number is {currentNumber}, the next is at most {half}");
		pot--;
	}
}
