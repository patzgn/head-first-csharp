using System.Collections;

namespace BetterSportSequence;

internal class BetterSportSequence : IEnumerable<Sport>
{
	public IEnumerator<Sport> GetEnumerator()
	{
		int maxEnumValue = Enum.GetValues(typeof(Sport)).Length;
		for (int i = 0; i < maxEnumValue; i++)
		{
			yield return (Sport)i;
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public Sport this[int index]
	{
		get => (Sport)index;
	}
}
