using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Test
    {
        static void Main(string[] args)
        {
            Demo1 d = new Demo2();
            d.fun1();
            d.fun2();
            d.fun3();
        }
    }
}
