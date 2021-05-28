using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameterExample
{
    public class Demo
    {
        public static void Main(string[] args)
        {
            Sample s = new Sample();
            s.fun1(out float d, out float e, out float f);
            Console.WriteLine($"sum ={ d }");
            Console.WriteLine($"Substraction ={e}");
            Console.WriteLine($"Multiplication ={f}");
        }
    }
}
