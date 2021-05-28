using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingLinkText
{
    public class Class1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://demostore.x-cart.com/";

            Thread.Sleep(2000);

            driver.FindElement(By.LinkText("Shipping")).Click();

            Thread.Sleep(2000);
           
            driver.FindElement(By.LinkText("Coming soon")).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.LinkText("New!")).Click();

            Thread.Sleep(2000);

            driver.FindElement(By.LinkText("Contact us")).Click();

            Thread.Sleep(2000);

        }
    }
}
