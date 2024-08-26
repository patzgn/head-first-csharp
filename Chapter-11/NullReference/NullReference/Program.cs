using (var stringReader = new StringReader(""))
{
    var nextLine = stringReader.ReadLine() ?? string.Empty;
    Console.WriteLine("Line length is: {0}", nextLine.Length);
}
