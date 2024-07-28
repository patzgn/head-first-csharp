namespace GoFish;

public class Player
{
	public static Random Random = new Random();

	private List<Card> _hand = new List<Card>();
	private List<Values> _books = new List<Values>();

	/// <summary>
	/// The cards in the player's hand
	/// </summary>
	public IEnumerable<Card> Hand => _hand;

	/// <summary>
	/// The books that the player has pulled out
	/// </summary>
	public IEnumerable<Values> Books => _books;

	public readonly string Name;

	/// <summary>
	/// Plurslize a word, adding "s" if a value isn't equal to 1
	/// </summary>
	public static string S(int s) => s == 1 ? "" : "s";

	/// <summary>
	/// Returns the current status of the player: the number of cards and books
	/// </summary>
	public string Status
		=> $"{Name} has {_hand.Count()} card{S(_hand.Count())} and {_books.Count()} book{S(_books.Count())}";

	/// <summary>
	/// Constructor to create a player
	/// </summary>
	/// <param name="name">Player's name</param>
	public Player(string name) => Name = name;

	/// <summary>
	/// Alternate constructor (used for unit testing)
	/// </summary>
	/// <param name="name">Player's name</param>
	/// <param name="cards">Initial set of cards</param>
	public Player(string name, IEnumerable<Card> cards)
	{
		Name = name;
		_hand.AddRange(cards);
	}

	/// <summary>
	/// Gets up to five cards from the stock
	/// </summary>
	/// <param name="stock">Stock to get the next hand from</param>
	public void GetNextHand(Deck stock)
	{
		while (stock.Count() > 0 && _hand.Count < 5)
		{
			_hand.Add(stock.Deal(0));
		}
	}

	/// <summary>
	/// If I have any cards that match the value, return them.
	/// If I run out of cards, get the next hand from the deck.
	/// </summary>
	/// <param name="value">Value I'm asked for</param>
	/// <param name="deck">Deck to draw my next hand from</param>
	/// <returns>The cards that were pulled out of the other player's hand</returns>
	public IEnumerable<Card> DoYouHaveAny(Values value, Deck deck)
	{
		var matchingCards = _hand.Where(card => card.Value == value)
			.OrderBy(card => card.Suit);

		_hand = _hand.Where(card => card.Value != value).ToList();

		if (_hand.Count == 0)
		{
			GetNextHand(deck);
		}

		return matchingCards;
	}

	/// <summary>
	/// When the player receives cards from another player, 
	/// adds them to the hand and pulls out any matching books
	/// </summary>
	/// <param name="cards">Cards from the other player to add</param>
	public void AddCardsAndPullOutBooks(IEnumerable<Card> cards)
	{
		_hand.AddRange(cards);

		var foundBooks = _hand
			.GroupBy(card => card.Value)
			.Where(group => group.Count() == 4)
			.Select(group => group.Key);

		_books.AddRange(foundBooks);
		_books.Sort();

		_hand = _hand
			.Where(card => !_books.Contains(card.Value))
			.ToList();
	}

	/// <summary>
	/// Draws a card from the stock and add it to the player's hand
	/// </summary>
	/// <param name="stock">Stock to draw a card from</param>
	public void DrawCard(Deck stock)
	{
		if (stock.Count > 0)
		{
			AddCardsAndPullOutBooks([stock.Deal(0)]);
		}
	}

	/// <summary>
	/// Gets a random value from the player's hand
	/// </summary>
	/// <returns>The value of randomly selected card in the player's hand</returns>
	public Values RandomValueFromHand()
		=> _hand.OrderBy(x => x.Value)
			   .Select(x => x.Value)
			   .Skip(Random.Next(_hand.Count()))
			   .First();

	public override string ToString() => Name;
}
