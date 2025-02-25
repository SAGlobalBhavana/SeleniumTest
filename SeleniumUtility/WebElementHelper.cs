using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HybridFramework.SeleniumUtility
{
    public static class WebElementHelper
    {
        public static void ClearAndSend(IWebDriver driver, By elementLocator, string sendnewvalue)
        {
            IWebElement Textfield = driver.FindElement(elementLocator);
            Textfield.SendKeys(Keys.Control + "A");
            Textfield.SendKeys(Keys.Delete);
            Thread.Sleep(1000);
            Textfield.SendKeys(sendnewvalue);
        }


        public static void Click_Clear_Send_Tab(IWebDriver driver, By elementLocator, string sendnewvalue)
        {
            IWebElement Textfield = driver.FindElement(elementLocator);
            Textfield.Click();
            Textfield.SendKeys(Keys.Control + "A");
            Textfield.SendKeys(Keys.Delete);
            Thread.Sleep(1000);
            Textfield.SendKeys(sendnewvalue + Keys.Tab);
        }
    }

}
