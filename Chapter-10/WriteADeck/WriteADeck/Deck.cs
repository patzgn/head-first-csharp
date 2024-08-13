using System.Collections.ObjectModel;

namespace WriteADeck;

class Deck : ObservableCollection<Card>
{
	private static Random random = new();

	public Deck()
	{
		Reset();
	}

	public Deck(string fileName)
	{
		using (var sr = new StreamReader(fileName))
		{
			while (!sr.EndOfStream)
			{
				var nextCard = sr.ReadLine();
				var cardParts = nextCard.Split(new char[] { ' ' });

				var value = cardParts[0] switch
				{
					"Ace" => Values.Ace,
					"Two" => Values.Two,
					"Three" => Values.Three,
					"Four" => Values.Four,
					"Five" => Values.Five,
					"Six" => Values.Six,
					"Seven" => Values.Seven,
					"Eight" => Values.Eight,
					"Nine" => Values.Nine,
					"Ten" => Values.Ten,
					"Jack" => Values.Jack,
					"Queen" => Values.Queen,
					"King" => Values.King,
					_ => throw new InvalidDataException($"Unrecognized card value: {cardParts[0]}")
				};

				var suit = cardParts[2] switch
				{
					"Diamonds" => Suits.Diamonds,
					"Clubs" => Suits.Clubs,
					"Hearts" => Suits.Hearts,
					"Spades" => Suits.Spades,
					_ => throw new InvalidDataException($"Unrecognized card suit: {cardParts[2]}")
				};

				Add(new Card(value, suit));
			}
		}
	}

	public void WriteCards(string fileName)
	{
		using (var sw = new StreamWriter(fileName))
		{
			foreach (var card in this)
			{
				sw.WriteLine(card.Name);
			}
		}
	}

	public void Reset()
	{
		Clear();

		for (int suit = 0; suit < 4; suit++)
		{
			for (int value = 1; value < 14; value++)
			{
				Add(new Card((Values)value, (Suits)suit));
			}
		}
	}

	public Card Deal(int index)
	{
		Card cardToDeal = base[index];
		RemoveAt(index);
		return cardToDeal;
	}

	public void Shuffle()
	{
		List<Card> copy = new(this);
		Clear();
		while (copy.Count > 0)
		{
			int index = random.Next(copy.Count);
			Card card = copy[index];
			copy.RemoveAt(index);
			Add(card);
		}
	}

	public void Sort()
	{
		List<Card> sortedCards = new(this);
		sortedCards.Sort(new CardComparerByValue());
		Clear();
		foreach (Card card in sortedCards)
		{
			Add(card);
		}
	}
}
