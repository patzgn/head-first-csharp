﻿using System.Collections;

namespace CreateSequencesByHand;

internal class ManualSportSequence : IEnumerable<Sport>
{
	public IEnumerator<Sport> GetEnumerator()
	{
		return new ManualSportEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
