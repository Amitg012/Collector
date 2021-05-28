using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolymorphism
{
    public class Child: Parent
    {
        public override void fun1()
        {
            Console.WriteLine("This is first function of child class");
        }
        public override void fun2()
        {
            Console.WriteLine("This is second function of child class");
        }
    }
}
