using System.Xml.Linq;
using System;

public class Drill : Tool
{

    public Drill(double weight):base("Drill",weight)
    {

    }

    public override void Describe()
    {
        Console.WriteLine($"A {_name}, used for making holes. Weight: {_weight} kg.");
    }


    public override void Use()
    {
        Console.WriteLine("Drilling holes...");
    }


}