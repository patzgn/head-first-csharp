namespace CardGroupQuery;

internal class Card : IComparable<Card>
{
	public Values Value { get; private set; }
	public Suits Suit { get; private set; }
	public string Name
	{
		get { return $"{Value} of {Suit}"; }
	}

	public Card(Values value, Suits suit)
	{
		Value = value;
		Suit = suit;
	}

	public override string ToString()
	{
		return Name;
	}

	public int CompareTo(Card other)
	{
		return new CardComparerByValue().Compare(this, other);
	}
}
