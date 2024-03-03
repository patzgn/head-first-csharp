namespace Chapter_3.SharpenYourPencil_2;

internal class Program
{
	static void Main(string[] args)
	{
		Pizzazz foxtrot = new() { Zippo = 2 };
		foxtrot.Bamboo(foxtrot.Zippo);
		Pizzazz november = new() { Zippo = 3 };
		Abracadabra tango = new() { Vavavoom = 4 };
		while (tango.Lala(november.Zippo))
		{
			november.Zippo *= -1;
			november.Bamboo(tango.Vavavoom);
			foxtrot.Bamboo(november.Zippo);
			tango.Vavavoom -= foxtrot.Zippo;
		}
		Console.WriteLine("november.Zippo = " + november.Zippo);
		Console.WriteLine("foxtrot.Zippo = " + foxtrot.Zippo);
		Console.WriteLine("tango.Vavavoom = " + tango.Vavavoom);
	}
}
