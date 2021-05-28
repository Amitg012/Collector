using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Demo
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.func("");

            s.func("Amit Ghodke");

            s.func(1, "AAAA");
   
        }
     
    }
}
