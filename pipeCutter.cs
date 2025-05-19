using System.Xml.Linq;
using System;

public class PipeCutter : Tool
{

    public PipeCutter(double weight):base("PipeCutter",weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine($"A {Name}, used to cut pipes. Weight: {Weight} kg.");
    }

    public override void Use()
    {
        Console.WriteLine("Cutting pipes cleanly...");
    }
}