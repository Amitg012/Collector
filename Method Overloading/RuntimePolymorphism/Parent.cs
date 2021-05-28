using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolymorphism
{
    public class Parent
    {
        public virtual void fun1()
        {
            Console.WriteLine("This is first function of parent class");

        }
        public virtual void fun2()
        {
            Console.WriteLine("This is second function of Parent class");


        }
    }
}
