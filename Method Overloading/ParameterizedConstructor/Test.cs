using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
   public class Test
    {
        static void Main(string[] args)
        {
            Demo1 d = new Demo1(46); // construtor itself work as a function
            d.fun(); //calling the function 
        }
    }
}
