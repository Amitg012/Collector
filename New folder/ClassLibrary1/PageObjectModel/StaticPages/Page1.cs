using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectModel.StaticPages
{
    class Page1
    {
        public static void email(IWebDriver driver)
        {
            IWebElement element1 = driver.FindElement(By.Id("email"));

            element1.SendKeys("Facebook");

            Thread.Sleep(2000);
        }
        public static void password(IWebDriver driver)
        {
            IWebElement element2 = driver.FindElement(By.Id("pass"));

            element2.SendKeys("Facebook");

            Thread.Sleep(2000);
        }
        public static void login(IWebDriver driver)
        {
            IWebElement element3 = driver.FindElement(By.Name("login"));

            element3.Click();

            Thread.Sleep(2000);
            

        }
        
    }
}
