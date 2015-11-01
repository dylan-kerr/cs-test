using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cs_test;

namespace cs_test.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var widget = Widget.MakeWidget();
            Console.WriteLine(widget);
        }
    }
}
