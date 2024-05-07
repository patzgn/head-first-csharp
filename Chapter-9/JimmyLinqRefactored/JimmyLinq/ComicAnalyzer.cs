namespace JimmyLinq;

public static class ComicAnalyzer
{
	public static IEnumerable<string> GetReviews(
		IEnumerable<Comic> catalog, IEnumerable<Review> reviews)
	{
		return catalog
			.OrderBy(comic => comic.Issue)
			.Join(
				reviews,
				comic => comic.Issue,
				review => review.Issue,
				(comic, review) =>
					$"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}");
	}

	public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(
		IEnumerable<Comic> catalog, IReadOnlyDictionary<int, decimal> prices)
	{
		return catalog
			.OrderBy(comic => prices[comic.Issue])
			.GroupBy(comic => CalculatePriceRange(comic, prices));
	}

	private static PriceRange CalculatePriceRange(Comic comic, IReadOnlyDictionary<int, decimal> prices)
	{
		if (prices[comic.Issue] < 100)
		{
			return PriceRange.Cheap;
		}
		return PriceRange.Expensive;
	}
}
