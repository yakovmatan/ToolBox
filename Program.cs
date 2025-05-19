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
            TheToolBox tools = new TheToolBox();
            tools.AddTool(new Drill(2.5));
            tools.AddTool(new Drill(2.3));
            tools.AddTool(new WireStripper(1.2));
            tools.Summery();
        }
    }
}
