using System.Xml.Linq;
using System;

public class WireStripper : Tool
{

    public WireStripper(double weight):base("WireStripper",weight,"cutting")
    {
    }


    public override void Describe()
    {
        Console.WriteLine($"A {Name}, used to strip insulation off wires. Weight: {Weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Stripping wires...");
    }


}
