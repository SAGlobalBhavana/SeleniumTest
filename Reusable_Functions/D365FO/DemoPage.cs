using EmpowerApps.SeleniumUtility;
using HybridFramework.ComonUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFramework.Reusable_Functions.D365FO
{
   
    public class DemoPage :TestBase
    {      
            public void SalesOrderCreation(FO_Reusable fO_Reusable)
            {
            //driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.NewButton)).Click();
            fO_Reusable.ClickNewButton();
            TimeWaitsHelper.WaitForVisible(driver, (By.XPath(FO_ElementRef.FO_CommonRef.NewCustomer)), 20);

            //cust value
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.NewCustomer)).SendKeys("000003");
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Site)).SendKeys("1");
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Warehouse)).SendKeys("11");
            //date
            DateTime date = DateTime.Now;
            string NewDate = date.ToString("M/dd/yyyy");
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ShippingDate)).Clear();
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ShippingDate)).SendKeys(NewDate);

            TimeWaitsHelper.WaitForVisible(driver, (By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK)), 20);

            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK)).Click();
            
               
            }      
    }
}
