using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_test
{
    public class Widget
    {
        private Widget()
        {
        }

        public static Widget MakeWidget()
        {
            return new Widget();
        }

        public override String ToString()
        {
            return "I'm a widget!";
        }
    }
}
