namespace NullReference;

public class Guy
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
        => $"a {Age}-year-old named {Name}";

    public Guy(int age, string name)
    {
        Age = age;
        Name = name;
    }
}
