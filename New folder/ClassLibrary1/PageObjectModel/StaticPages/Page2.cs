using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectModel.StaticPages
{
    class Page2
    {
        public static void HotDetails(IWebDriver driver)
        {
            IList < IWebElement > element1 = driver.FindElements(By.ClassName("primary-title"));

            Thread.Sleep(3000);

            Actions action = new Actions(driver);

            action.MoveToElement(element1[1]).Build().Perform();

           Thread.Sleep(2000);
        }
        public static void sale(IWebDriver driver)
        {
            IWebElement element2 = driver.FindElement(By.LinkText("Sale"));

            Thread.Sleep(2000);

            element2.Click();
        }
    }
}
