namespace JoeAndBob;

internal class Program
{
	static void Main(string[] args)
	{
		Guy joe = new() { Name = "Joe", Cash = 50 };
		Guy bob = new() { Name = "Bob", Cash = 100 };

		while (true)
		{
			joe.WriteMyInfo();
			bob.WriteMyInfo();

			Console.Write("Enter an amount: ");
			string howMuch = Console.ReadLine();
			if (howMuch == "") return;
			if (int.TryParse(howMuch, out int amount))
			{
				Console.Write("Who should give the cash: ");
				string whichGuy = Console.ReadLine();
				if (whichGuy == "Joe")
				{
					int cashGiven = joe.GiveCash(amount);
					bob.ReceiveCash(cashGiven);
				}
				else if (whichGuy == "Bob")
				{
					int cashGiven = bob.GiveCash(amount);
					joe.ReceiveCash(cashGiven);
				}
				else
				{
					Console.WriteLine("Please enter 'Joe' or 'Bob'");
				}
			}
			else
			{
				Console.WriteLine("Please enter an amount (or a blank line to exit).");
			}
		}

	}
}
