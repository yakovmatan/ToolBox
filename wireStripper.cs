using System.Xml.Linq;
using System;

public class WireStripper : Tool
{

    public WireStripper(double weight):base("WireStripper",weight)
    {
    }


    public override void Describe()
    {
        Console.WriteLine($"A {_name}, used to strip insulation off wires. Weight: {_weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Stripping wires...");
    }


}
