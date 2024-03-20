namespace ScaryClown;

internal class ScaryScary : FunnyFunny, IScaryClown
{
	private readonly int scaryThingCount;

	public string ScaryThingIHave { get { return $"{scaryThingCount} spiders"; } }

	public ScaryScary(string funnyThingIHave, int scaryThingCount) : base(funnyThingIHave)
	{
		this.scaryThingCount = scaryThingCount;
	}

	public void ScareLittleChildren()
	{
		Console.WriteLine($"Boo! Gotcha! Look at my {ScaryThingIHave}!");
	}
}
