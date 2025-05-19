using System.Xml.Linq;
using System;

public class NailGun : Tool
{

    public NailGun(double weight):base("NailGun",weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine($"A {Name}, fires nails quickly. Weight: {Weight} kg.");
    }


    public override void Use()
    {
        Console.WriteLine("Firing nails...");

    }
}

