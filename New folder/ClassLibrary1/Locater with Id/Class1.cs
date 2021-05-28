using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Locater_with_Id
{
    public class Class1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.facebook.com/";

            Thread.Sleep(2000);
            IWebElement element1 = driver.FindElement(By.Id("email"));

            element1.SendKeys("Facebook");

            Thread.Sleep(2000);

            // Locating address of password text field webelement 

            IWebElement element2 = driver.FindElement(By.Id("pass"));

            element2.SendKeys("Facebook");

            Thread.Sleep(2000);

            IWebElement element3 = driver.FindElement(By.Id("loginbutton"));

            element3.Click();

            Thread.Sleep(2000);





        }
    }
}
