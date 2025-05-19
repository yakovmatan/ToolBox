using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tool> toolBox = new List<Tool>();
            toolBox.Add(new Drill(2.5));
            toolBox.Add(new Drill(2.6));
            toolBox.Add(new Hammer(4.1));
            toolBox.Add(new Screwdriver(1.1));
            toolBox.Add(new Saw(2.9));

            foreach (var tool in toolBox)
            {
                tool.Describe();
                tool.Use();
            }
        }
    }
}
