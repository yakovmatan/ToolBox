using System;
using System.Collections.Generic;

public class TheToolBox
{
    private Dictionary<string, List<Tool>> tools = new Dictionary <string,List<Tool>>();

    public void AddTool(Tool tool)
    {
        if (!tools.ContainsKey(tool.ToolCategory))
        {
            tools[tool.ToolCategory] = new List<Tool>();
        }
        tools[tool.ToolCategory].Add(tool);
    }

    public void Summery()
    {
        foreach (var category in tools)
        {
            Console.WriteLine($"category: {category.Key}");

            foreach (var tool in category.Value)
            {
                Console.WriteLine($"name: {tool.Name} weight: {tool.Weight}");
            }

            Console.WriteLine();
        }
    }

}