using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Sample
    {
        public void fun(int i)
        {
            Console.WriteLine("Id of the person==" + i);
        }
        public void func(string s)
        {
            Console.WriteLine("Name of the person==" + s);
        }
        public void func(int i, string s)
        {
            Console.WriteLine("Id of the person==" + i);
            Console.WriteLine("Name of the person==" + s);

        }
    }
}
