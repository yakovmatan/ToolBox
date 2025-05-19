using System.Xml.Linq;
using System;

public class Wranch : Tool
{
    public Wranch(double weight):base("wranch",weight,"driling")
    {
    }

    public override void Describe()
    {

        Console.WriteLine($"A {Name}, used to tighten or loosen bolts. Weight: {Weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Turning bolts...");
    }



}