using System.Xml.Linq;
using System;

public class Saw : Tool
{

    public Saw(double weight):base("Saw",weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine($"A {_name}, used for cutting materials. Weight: {_weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Sawing wood...");
    }
}