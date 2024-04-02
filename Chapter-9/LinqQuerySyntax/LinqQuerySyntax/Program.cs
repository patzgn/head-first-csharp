namespace LinqQuerySyntax;

internal class Program
{
    static void Main(string[] args)
    {
        int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };

        IEnumerable<int> result =
            from v in values
            where v < 37
            orderby -v
            select v;

        foreach (int i in result)
        {
            Console.Write($"{i} ");
        }
    }
}
