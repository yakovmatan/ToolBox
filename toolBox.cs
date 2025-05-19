using System;

public class Tool
{

    protected string _name;
    protected int _weight;


    public Tool(string Name,int Weight)
    {
        this._name = Name;
        this._weight = Weight;
    }

    public void Describe()
    {
        Console.WriteLine($"name of the tool is: {_name}");
        Console.WriteLine($"the weight of the tool is: {_weight}");
    }

    public void Use()
    {
        Console.WriteLine("Tool is being used");
    }
}