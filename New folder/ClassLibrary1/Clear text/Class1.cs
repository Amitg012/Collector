using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clear_text
{
    public class Class1
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            // CLEAR TEXT

            //driver.Url = "https://demostore.x-cart.com/";

            //Thread.Sleep(2000);

            //IWebElement element = driver.FindElement(By.CssSelector("input[name='substring']"));
            //element.SendKeys("iphone");

            //Thread.Sleep(3000);

            //element.Clear();

            //element.SendKeys("samsung");

            //ENTER ELEMENT IN SEARCH BOX

            //driver.Url = "https://www.google.ie/";

            //Thread.Sleep(2000);

            ////IWebElement element = driver.FindElement(By.CssSelector(".gLFyf.gsfi"));
            //IWebElement element = driver.FindElement(By.Name("q"));

            //element.SendKeys("Facebook");

            //Thread.Sleep(3000);

            //element.SendKeys(Keys.Enter);

            //Thread.Sleep(3000);

            //MOUSE HOVER (here we need to Import)
            //org.openqa.selenium.interactions.Actions 

            //driver.Url = "https://demostore.x-cart.com/";

            //Thread.Sleep(2000);

            //IList<IWebElement> element1 = driver.FindElements(By.ClassName("primary-title"));

            //Thread.Sleep(3000);

            //Actions action = new Actions(driver);

            //action.MoveToElement(element1[1]).Build().Perform();

            //Thread.Sleep(2000);

            //IWebElement element2 = driver.FindElement(By.LinkText("Sale"));

            //Thread.Sleep(2000);

            //element2.Click();

            // Select Drop Downs 

            //driver.Url = "http://demo.guru99.com/test/newtours/register.php";

            //Thread.Sleep(3000);

            //SelectElement element = new SelectElement(driver.FindElement(By.Name("country")));

            //Thread.Sleep(2000);
            //element.SelectByText("BELGIUM");

            //Thread.Sleep(3000);


            //DRAG AND DROP
            //driver.Url = "https://testzenlabs.ie/education-form/";

            //Thread.Sleep(2000);

            //Actions action = new Actions(driver);

            //IWebElement element = driver.FindElement(By.CssSelector("#myRange2"));

            //Thread.Sleep(2000);

            //action.ClickAndHold(element).MoveByOffset(22, 0).Release().Build().Perform();

            //Thread.Sleep(4000);

            //action.ClickAndHold(element).MoveByOffset(-40, 0).Release().Build().Perform();


            //Thread.Sleep(2000);

            //driver.Quit();


            //Open the last window
            //driver.Url = "https://demostore.x-cart.com/";

            //Thread.Sleep(2000);

            //IWebElement element = driver.FindElement(By.LinkText("Create your store"));

            //Thread.Sleep(2000);

            //element.Click();
            //Thread.Sleep(3000);
            //driver.SwitchTo().Window(driver.WindowHandles.Last());

            //Thread.Sleep(3000);
            //driver.Quit();


            //open new window and nevigate between multiple windows

            driver.Url = "https://demostore.x-cart.com/";

            Thread.Sleep(3000);

            ((IJavaScriptExecutor)driver).ExecuteScript("window.open");

            Thread.Sleep(2000);

            driver.SwitchTo().Window(driver.WindowHandles.Last());

            driver.Url = "https://testzenlabs.ie/education-form/#";
            Thread.Sleep(3000);

            driver.SwitchTo().Window(driver.WindowHandles.First());

            Thread.Sleep(2000);

            driver.Quit();










        }


    }
}
