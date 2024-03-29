namespace TwoDecksBlazor;

public class TwoDecks
{
	private Deck leftDeck = new();
	private Deck rightDeck = new();

	public int LeftDeckCount { get { return leftDeck.Count; } }
	public int RightDeckCount { get { return rightDeck.Count; } }

	public int LeftCardSelected { get; set; }
	public int RightCardSelected { get; set; }

	public string LeftDeckCardName(int i)
	{
		return leftDeck[i].ToString();
	}

	public string RightDeckCardName(int i)
	{
		return rightDeck[i].ToString();
	}

	public void Shuffle()
	{
		leftDeck.Shuffle();
	}

	public void Reset()
	{
		leftDeck.Reset();
	}

	public void Sort()
	{
		rightDeck.Sort(new CardComparerByValue());
	}

	public void Clear()
	{
		rightDeck.Clear();
	}

	public void MoveCard(Direction direction)
	{
		if (direction == Direction.LeftToRight)
		{
			rightDeck.Add(leftDeck[LeftCardSelected]);
			leftDeck.RemoveAt(LeftCardSelected);
		}
		else
		{
			leftDeck.Add(rightDeck[RightCardSelected]);
			rightDeck.RemoveAt(RightCardSelected);
		}
	}
}
