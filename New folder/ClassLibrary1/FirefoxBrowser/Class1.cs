using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirefoxBrowser
{
    public class Class1
    {
        static void Main(string[] args)
        {
            var op = new FirefoxOptions
            {
                AcceptInsecureCertificates = true
            };

            IWebDriver driver = new FirefoxDriver(op);

            driver.Manage().Window.Maximize();

            driver.Url = "https://testzenlabs.ie//";

            Thread.Sleep(2000);

            driver.Quit();



        }
    }
}
