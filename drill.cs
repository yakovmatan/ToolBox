using System.Xml.Linq;
using System;

public class Drill : Tool
{

    public Drill(double weight):base("Drill",weight,"driling")
    {

    }

    public override void Describe()
    {
        Console.WriteLine($"A {Name}, used for making holes. Weight: {Weight} kg.");
    }


    public override void Use()
    {
        Console.WriteLine("Drilling holes...");
    }


}