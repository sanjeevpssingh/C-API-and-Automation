using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assignment.Base_Driver
{
    public class Driver
    {
        public static IWebDriver driver;
        // public static String Url = "http://automationpractice.com/index.php";

        public void invokeDriver()
        {
            driver = new ChromeDriver();
            

        }
        public void OpenUrl()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }



        public void closeDriver()
        {
            driver.Close();
        }
    }
}
