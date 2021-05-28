using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameterExample
{
   public class Sample
    {
        int i = 10;
        float f = 10.5f;
        public void fun1(out float a, out float b, out float c)
        {
            a = i + f;
            b = i - f;
            c = i * f;
        }
    }
}
