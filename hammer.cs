using System;

public class Hammer : Tool
{
    public Hammer(string Name, int Weight):base(Name, Weight)
    {

    }

    public override void Describe()
    {
        Console.WriteLine($"A {_name}, great for pounding nails. weight: {_weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Hammering nails into wood...");
    }
}