using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
   public class Sample
    {
        static void Main(string[] args)
        {
            Demo1 d1 = new Demo1();
            Console.WriteLine($"Salary of Employee ={d1.Salary}");
            d1.Salary = 20000;

            Console.WriteLine($"Salary of Employee = {d1.Salary}");
                }

    }
}
