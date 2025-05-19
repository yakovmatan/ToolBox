using System.Xml.Linq;
using System;

public class NailGun : Tool
{

    public NailGun(double weight):base("NailGun",weight)
    {
    }

    public override void Describe()
    {
        Console.WriteLine($"A {_name}, fires nails quickly. Weight: {_weight} kg.");
    }


    public override void Use()
    {
        Console.WriteLine("Firing nails...");

    }
}

