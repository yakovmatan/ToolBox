using System.Xml.Linq;
using System;

public class Wranch : Tool
{
    public Wranch(double weight):base("wranch",weight)
    {
    }

    public override void Describe()
    {

        Console.WriteLine($"A {_name}, used to tighten or loosen bolts. Weight: {_weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Turning bolts...");
    }



}