using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjectModel.StaticPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PageObjectModel.TestCases
{
    class TestCases
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Url = "https://www.facebook.com/";

            Thread.Sleep(2000);

            Page1.email(driver);
            Page1.password(driver);
            Page1.login(driver);
            Thread.Sleep(2000);

            driver.Url = "http://demostore.x-cart.com/";

            Thread.Sleep(2000);

            Page2.HotDetails(driver);

            Thread.Sleep(2000);

            Page2.sale(driver);
            driver.Quit();



        }
    }
}
