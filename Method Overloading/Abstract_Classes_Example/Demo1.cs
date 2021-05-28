using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Example
{
    public abstract class Demo1
    {
        public abstract void fun1();
        public void fun2()
        {
            Console.WriteLine("this is second function");
        }
        public abstract void fun3();
    }
}
