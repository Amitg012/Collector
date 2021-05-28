using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    public class Demo1
    {
        private double _Salary = 10000;
        public double Salary
        {
            set { _Salary = value; }
            get { return _Salary; }
        }
    }
}
