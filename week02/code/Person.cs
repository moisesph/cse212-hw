public class Person
{
    public readonly string Name;
    public int Turns { get; set; }

    public bool Infinite { get; set; } = false; //This will help to know if they have infinity opportunities

    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;
    }

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}