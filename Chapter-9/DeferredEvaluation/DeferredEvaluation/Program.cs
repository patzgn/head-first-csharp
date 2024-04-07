namespace DeferredEvaluation;

internal class Program
{
	static void Main(string[] args)
	{
		var listOfObjects = new List<PrintWhenGetting>();
		for (int i = 0; i < 5; i++)
		{
			listOfObjects.Add(new PrintWhenGetting() { InstanceNumber = i });
		}

		Console.WriteLine("Set up the query");
		var result =
			from o in listOfObjects
			select o.InstanceNumber;

		Console.WriteLine("Run the foreach");
		foreach (var number in result)
		{
			Console.WriteLine($"Writing #{number}");
		}

		var immediate = result.ToList();

		Console.WriteLine("Run the foreach");
		foreach (var number in immediate)
		{
			Console.WriteLine($"Writing #{number}");
		}
	}
}
