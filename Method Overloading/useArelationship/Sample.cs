using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useArelationship
{
   public class Sample
    {
        static void Main(string[] args)
        {
            Demo1 dd = new Demo1();
            Demo2 s = new Demo2();
            s.fun3(dd);

        }
    }
}
