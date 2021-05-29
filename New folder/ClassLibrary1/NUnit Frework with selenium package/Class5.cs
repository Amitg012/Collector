using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit_Frework_with_selenium_package
{
    [TestFixture]
    class Class5:Class1
    {
        [Test]
        [Category("Smoke")]
        public void fun1()
        {
            driver.Url = "https://demostore.x-cart.com/";

            Thread.Sleep(2000);

            IWebElement element = driver.FindElement(By.CssSelector("input[name='substring']"));
            element.SendKeys("iphone");

            Thread.Sleep(3000);

            element.Clear();

            element.SendKeys("samsung");

            Thread.Sleep(2000);
        }
        [Test]
        public void fun2()
        {
            driver.Url = "https://www.google.ie/";

            Thread.Sleep(2000);

            //IWebElement element = driver.FindElement(By.CssSelector(".gLFyf.gsfi"));
            IWebElement element = driver.FindElement(By.Name("q"));

            element.SendKeys("Facebook");

            Thread.Sleep(3000);

            element.SendKeys(Keys.Enter);

            Thread.Sleep(3000);
        }
        [Test]
        public void fun3()
        {
            driver.Url = "https://www.facebook.com/";

            Thread.Sleep(2000);
            IWebElement element1 = driver.FindElement(By.Id("email"));

            element1.SendKeys("Facebook");

            Thread.Sleep(2000);

            // Locating address of password text field webelement 

            IWebElement element2 = driver.FindElement(By.Id("pass"));

            element2.SendKeys("Facebook");

            Thread.Sleep(2000);

            IWebElement element3 = driver.FindElement(By.Name("login"));

            element3.Click();

            Thread.Sleep(2000);
        }

    }
}
