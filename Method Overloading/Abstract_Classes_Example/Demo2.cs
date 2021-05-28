using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Example
{
    public class Demo2 :Demo1
    {
        public override void fun1()
        {
            Console.WriteLine("this is first function");
        }
        public override void fun3()
        {
            Console.WriteLine("This is third function");
        }
    }
}
