using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    public class NUnitattributeexamples
    {
        [OneTimeSetUp]
        public void OneTimeSetUpMethod()
        {
            Console.WriteLine("Invoking one time set up Method");
        }

        [SetUp]
        public void SetupMethod()
        {
            Console.WriteLine("Invoking Setup Method");
        }

        [Test]
        public void fun1()
        {
            Console.WriteLine("Invoking first method");
        }
        [Test]
        public void fun2()
        {
            Console.WriteLine("Invokng Second Method");
        }
        [Test]
        public void fun3()
        {
            Console.WriteLine("Invoking Third Method");
        }
        [Test]
        public void fun4()
        {
            Console.WriteLine("Invoking Forth Method");
        }
        [TearDown]
        public void TearDownMethod()
        {
            Console.WriteLine("Invoking Tear Down Method");
        }

        [OneTimeTearDown]
        public void OneTimeTearDownMethod()
        {
            Console.WriteLine("Invoking one time tear down method");
        }

    }
}
