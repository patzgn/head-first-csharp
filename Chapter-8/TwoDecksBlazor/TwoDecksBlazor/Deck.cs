namespace TwoDecksBlazor;

class Deck : List<Card>
{
	private static Random random = new();

	public Deck()
	{
		Reset();
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
}
