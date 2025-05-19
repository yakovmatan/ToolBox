using System.Xml.Linq;
using System;

public class PipeCutter : Tool
{

    public PipeCutter(double weight):base("PipeCutter",weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine($"A {_name}, used to cut pipes. Weight: {_weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Cutting pipes cleanly...");
    }
}