namespace PlanetMission;

internal class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine(new Venus().MissionInfo());
		Console.WriteLine(new Mars().MissionInfo());
		//Console.WriteLine(new PlanetMission().MissionInfo());
	}
}
