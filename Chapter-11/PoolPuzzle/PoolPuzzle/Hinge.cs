namespace PoolPuzzle;

public class Hinge
{
    public int bulb;
    public Table garden;

    public void Set(Table a) => garden = a;

    public string Table()
    {
        return garden.stairs;
    }
}
