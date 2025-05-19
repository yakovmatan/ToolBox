using System.Xml.Linq;
using System;

public class Screwdriver : Tool

{
    public Screwdriver(double weight):base("Scrwdriver",weight,"fastening")
    {
    }

    public override void Describe()
    {
        Console.WriteLine($"A {Name}, perfect for driving screws. Weight: {Weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Turning screws...");
    }
}