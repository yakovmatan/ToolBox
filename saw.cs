using System.Xml.Linq;
using System;

public class Saw : Tool
{

    public Saw(double weight):base("Saw",weight,"cutting")
    {
    }

    public override void Describe()
    {
        Console.WriteLine($"A {Name}, used for cutting materials. Weight: {Weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Sawing wood...");
    }
}