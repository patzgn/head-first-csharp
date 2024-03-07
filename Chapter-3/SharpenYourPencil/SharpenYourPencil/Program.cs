namespace SharpenYourPencil;

internal class Program
{
	static void Main(string[] args)
	{
		Clown oneClown = new();
		oneClown.Name = "Boffo";
		oneClown.Height = 172;
		oneClown.TalkAboutYourself();

		Clown anotherClown = new();
		anotherClown.Name = "Biff";
		anotherClown.Height = 180;
		anotherClown.TalkAboutYourself();

		Clown clown3 = new();
		clown3.Name = anotherClown.Name;
		clown3.Height = oneClown.Height - 3;
		clown3.TalkAboutYourself();

		anotherClown.Height *= 2;
		anotherClown.TalkAboutYourself();
	}
}
