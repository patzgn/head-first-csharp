using PoolPuzzle;

Kangaroo joey = new Kangaroo();
int koala = joey.Wombat(
    joey.Wombat(joey.Wombat(1)));
try
{
    Console.WriteLine((15 / koala)
        + " ggs per pound");
}
catch (DivideByZeroException)
{
    Console.WriteLine("G'Day Mate!");
}
