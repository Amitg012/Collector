using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Xpath
{
    public class Class1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://demostore.x-cart.com/";

            //Thread.Sleep(2000);

            driver.FindElement(By.XPath(".//a[contains(text(),'Create your store')]")).Click();

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
    }
}
