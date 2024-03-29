namespace LumberjacksAndFlapjacks;

internal class Program
{
	static void Main(string[] args)
	{
		Random random = new();
		Queue<Lumberjack> lumberjacks = new();

		string name;
		Console.Write("First lumberjack's name: ");
		while ((name = Console.ReadLine()) != "")
		{
			Console.Write("Number of flapjacks: ");
			if (int.TryParse(Console.ReadLine(), out int number))
			{
				Lumberjack lumberjack = new(name);
				for (int i = 0; i < number; i++)
				{
					lumberjack.TakeFlapjack((Flapjack)random.Next(4));
				}
				lumberjacks.Enqueue(lumberjack);
			}
			Console.Write("Next lumberjack's name (blank to end): ");
		}

		while (lumberjacks.Count > 0)
		{
			Lumberjack next = lumberjacks.Dequeue();
			next.EatFlapjacks();
		}
	}
}
