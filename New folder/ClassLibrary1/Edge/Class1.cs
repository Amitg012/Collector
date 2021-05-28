using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Edge
{
    public class Class1
    {
        static void Main(string[] args)
        {
            var path = $"{AppDomain.CurrentDomain.BaseDirectory}\\Driver";

            var options = new EdgeOptions();

            options.UseChromium = true;

            IWebDriver driver = new EdgeDriver(path, options);

            driver.Manage().Window.Maximize();

            driver.Url = "https://testzenlabs.ie/";

            Thread.Sleep(3000);

            driver.Quit();

        }
    }
}
