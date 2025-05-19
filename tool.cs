using System;

public class Tool
{

    public string Name { get; }
    public double Weight { get; }

    public string ToolCategory { get; }


    public Tool(string Name,double Weight,string toolCategory)
    {
        this.Name = Name;
        this.Weight = Weight;
        this.ToolCategory = toolCategory;

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