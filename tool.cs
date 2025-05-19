using System;

public class Tool
{

    public string Name { get; }
    public double Weight;


    public Tool(string Name,double Weight)
    {
        this.Name = Name;
        this.Weight = Weight;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"name of the tool is: {Name}");
        Console.WriteLine($"the weight of the tool is: {Weight}");
    }

    public virtual void Use()
    {
        Console.WriteLine("Tool is being used");
    }
}