﻿namespace PoolPuzzle;

internal class Party
{
	private StreamReader reader;

	public Party(StreamReader reader)
	{
		this.reader = reader;
	}

	public void HowMuch(StreamWriter q)
	{
		q.WriteLine(reader.ReadLine());
		reader.Close();
	}
}
