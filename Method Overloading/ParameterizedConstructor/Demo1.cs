using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
    public class Demo1
    {
        public Demo1(int i)
        {
            Console.WriteLine("Employer Id=" + i);
        }
        public void fun()
        {
            Console.WriteLine("this is the first function");
        }
    }
}
