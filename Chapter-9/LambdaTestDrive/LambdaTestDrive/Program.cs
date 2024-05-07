namespace LambdaTestDrive;

internal class Program
{
	static Random Random => new();

	static double GetRandomDouble(int max) => max * Random.NextDouble();

	static void PrintValue(double d) => Console.WriteLine($"The value is {d:0.0000}.");

	static void Main(string[] args)
	{
		var value = GetRandomDouble(100);
		PrintValue(value);
	}
}
