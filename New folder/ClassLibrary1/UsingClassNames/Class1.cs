using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UsingClassNames
{
    public class Class1

    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.facebook.com/";

            Thread.Sleep(2000);

            IList<IWebElement> elements1 = driver.FindElements(By.ClassName("inputtext"));

            elements1[0].SendKeys("Facebook");

            Thread.Sleep(2000);

            // Locating address of password text field webelement 

            IList<IWebElement> elements2 = driver.FindElements(By.ClassName("inputtext"));

            elements2[1].SendKeys("Facebook");

            Thread.Sleep(2000);

            IWebElement element3 = driver.FindElement(By.Id("loginbutton"));

            element3.Click();

            Thread.Sleep(2000);



        }
    }
}
