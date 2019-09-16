using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Book_Flight.Base
{
    public class Driver
    {
        public static IWebDriver driver;
        // public static String Url = "https://www.expedia.com/";

        public void invokeDriver()
        {
            driver = new ChromeDriver();


        }
        public void OpenUrl()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.expedia.com/");
        }



        public void closeDriver()
        {
            driver.Close();
        }
    }
}
