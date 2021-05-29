using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit_Frework_with_selenium_package
{
    public class Class1
    {
        public IWebDriver driver = null;
        [OneTimeSetUp]
        public void OneTimeSetupMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [OneTimeTearDown]
        public void OneTimeTearDownMethod()
        {
            driver.Quit();
        }
    }
}
