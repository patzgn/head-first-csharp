﻿namespace StreamWriterMagnets;

internal class Program
{
	static void Main(string[] args)
	{
		Flobbo f = new Flobbo("blue yellow");
		StreamWriter sw = f.Snobbo();
		f.Blobbo(f.Blobbo(f.Blobbo(sw), sw), sw);
	}
}
