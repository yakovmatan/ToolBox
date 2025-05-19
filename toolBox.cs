using System;
using System.Collections.Generic;

public class TheToolBox
{
    private List<Tool> tools = new List<Tool>();

    public void AddTool(Tool tool)
    {
        tools.Add(tool);
    }

    public void Summery()
    {
        foreach (var tool in tools)
        {
            Console.WriteLine(tool.Name);
            Console.WriteLine(tool.Weight);
        }
    }

}