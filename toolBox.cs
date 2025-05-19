using System;

public class Tool
{

    protected string _name;
    protected double _weight;


    public Tool(string Name,double Weight)
    {
        this._name = Name;
        this._weight = Weight;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"name of the tool is: {_name}");
        Console.WriteLine($"the weight of the tool is: {_weight}");
    }

    public virtual void Use()
    {
        Console.WriteLine("Tool is being used");
    }
}