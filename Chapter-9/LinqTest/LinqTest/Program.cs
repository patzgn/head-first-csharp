namespace LinqTest;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new();
        for (int i = 1; i <= 99; i++)
        {
            numbers.Add(i);
        }
        IEnumerable<int> firstAndLastFive =
            numbers.Take(5).Concat(numbers.TakeLast(5));
        foreach (int i in firstAndLastFive)
        {
            Console.Write($"{i} ");
        }
    }
}
