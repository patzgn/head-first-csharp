namespace JimmyLinq;

public static class ComicAnalyzer
{
	public static IEnumerable<string> GetReviews(
		IEnumerable<Comic> catalog, IEnumerable<Review> reviews)
	{
		return
			from comic in catalog
			orderby comic.Issue
			join review in reviews
			on comic.Issue equals review.Issue
			select $"{review.Critic} rated #{comic.Issue} '{comic.Name}' {review.Score:0.00}";
	}

	public static IEnumerable<IGrouping<PriceRange, Comic>> GroupComicsByPrice(
		IEnumerable<Comic> catalog, IReadOnlyDictionary<int, decimal> prices)
	{
		return
			from comic in catalog
			orderby prices[comic.Issue]
			group comic by CalculatePriceRange(comic, prices);
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
