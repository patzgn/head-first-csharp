namespace WriteADeck;

internal class Program
{
	static void Main(string[] args)
	{
		var fileName = "deckofcards.txt";
		Deck deck = new Deck();
		deck.Shuffle();
		for (int i = deck.Count - 1; i > 10; i--)
		{
			deck.RemoveAt(i);
		}
		deck.WriteCards(fileName);

		Deck cardsToRead = new Deck(fileName);
		foreach (var card in cardsToRead)
		{
			Console.WriteLine(card.Name);
		}
	}
}
