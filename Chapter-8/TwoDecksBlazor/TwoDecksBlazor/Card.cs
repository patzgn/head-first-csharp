﻿namespace TwoDecksBlazor;

internal class Card
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
}
