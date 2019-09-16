using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assignment.Base_Driver;
using NUnit.Framework;
using System.Threading;
using Assignment.Comm_Utils;

namespace Assignment.Comm_Utils
{
    [Binding]
    public class SignInWithNoCredentialsSteps: Driver
    {
        string expectedoutput = " ";
       
        [Given(@"we are on Login page")]
        public void GivenWeAreOnLoginPage()
        {
            try
            {
                invokeDriver();
                driver.Manage().Window.Maximize();
                OpenUrl();
            }

            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Error in opening browser");
            }
            

        }

       
       

        [When(@"Click on Sign In")]
        public void WhenClickOnSignIn()
        {
            driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")).Click();
        }

        [When(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string email, string password)
        {
            driver.FindElement(By.Id("email")).SendKeys(email);
            driver.FindElement(By.Id("passwd")).SendKeys(password);
            try {
                if (email == "" && password == "")
                {
                    expectedoutput = "An email address required.";
                }
                else if (password == "")
                {
                    expectedoutput = "Password is required.";
                }
                else if (email == "")
                {
                    expectedoutput = "An email address required.";
                }
                else
                {
                    expectedoutput = "Authentication failed.";
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Error in passing values");

            }
        }


        [When(@"user Click on Sign In Button")]
        public void WhenUserClickOnSignInButton()
        {
            driver.FindElement(By.Id("SubmitLogin")).Click();
        }

        [Then(@"An email address required should be visible")]
        public void ThenAnEmailAddressRequiredShouldBeVisible()
        {
            try {
                IWebElement element = driver.FindElement(By.XPath(" //*[@id='center_column']/div[1]/ol/li"));

                string actualoutput = element.GetAttribute("innerHTML");
                Assert.AreEqual(expectedoutput, actualoutput);
                System.Threading.Thread.Sleep(3000);
                driver.Quit();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Error in assertion");

            }
        }
       


    }
}
