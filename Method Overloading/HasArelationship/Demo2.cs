using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasArelationship
{
    public class Demo2
    {
        private int i = (10);
        private string s = "Amit";
        private Demo1 d;

        public Demo2()
        {
            d = new Demo1();
            d.fun1();
            d.fun2();

        }
        public void fun3()
        {
            Console.WriteLine("Id == " + i);
        }
       
    }
}
