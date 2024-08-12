namespace PoolPuzzle;

internal class Pineapple
{
	const string d = "delivery.txt";

	public enum Fargo { North, South, East, West, Flamingo }

	public static void Main(string[] args)
	{
		StreamWriter o = new StreamWriter("order.txt");
		var pz = new Pizza(new StreamWriter(d, true));
		pz.Idaho(Fargo.Flamingo);
		for (int w = 3; w >= 0; w--)
		{
			var i = new Pizza(new StreamWriter(d, false));
			i.Idaho((Fargo)w);
			Party p = new Party(new StreamReader(d));
			p.HowMuch(o);
		}

		o.WriteLine("That’s all folks!");
		o.Close();
	}
}
