using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Assignment.commonUtils
{
    public class commonUtils
    {
        public static Boolean typetext(IWebElement forward, String value)
        {
            try
            {
                if (forward != null && value != null)
                {
                    forward.Clear();
                    forward.SendKeys(value);
                    return true;
                }
                else
                {
                    Console.WriteLine("Null parameter found");
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
        public static Boolean press(IWebElement go)
        {
            if (go != null)
            {
                go.Click();
                return true;
            }
            else
            {
                Console.WriteLine("Null parameter found");
                return false;
            }
        }
    }
}
