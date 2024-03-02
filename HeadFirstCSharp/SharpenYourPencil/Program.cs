namespace SharpenYourPencil;

internal class Program
{
	static void Main(string[] args)
	{
		TryAnIf();
		TrySomeLoop();
		TryAnIfElse();
	}

	private static void TryAnIfElse()
	{
		int x = 5;
		if (x == 10)
		{
			Console.WriteLine("x must be 10");
		}
		else
		{
			Console.WriteLine("x isn't 10");
		}
	}

	private static void TrySomeLoop()
	{
		int count = 0;

		while (count < 10)
		{
			count = count + 1;
		}

		for (int i = 0; i < 5; i++)
		{
			count = count - 1;
		}

		Console.WriteLine("The answer is " + count);
	}

	private static void TryAnIf()
	{
		int someValue = 4;
		string name = "Bobbo Jr.";
		if ((someValue == 3) && (name == "Joe"))
		{
			Console.WriteLine("x is 3 and the name is Joe");
		}
		Console.WriteLine("this line runs no matter what");
	}
}
