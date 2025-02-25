using AventStack.ExtentReports.Gherkin.Model;
using EmpowerApps.SeleniumUtility;
using HybridFramework.ComonUtilities;
using HybridFramework.SeleniumUtility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OfficeOpenXml.Style;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace HybridFramework.Reusable_Functions.D365FO
{
    [TestClass]
    class FO_PurchaseOrderPage :TestBase
    {
        [TestMethod]
        public void NavigateToUKEntity()
        {          
            WebElementHelper.ClearAndSend(driver,By.XPath(FO_ElementRef.FO_CommonRef.LegalEntity), "UK60");
        }
            public void NavigateToAllProjects()
        {
            string ActTitle = driver.FindElement(By.CssSelector(FO_ElementRef.FO_CommonRef.DashboardTitle)).Text;           
            Assert.AreEqual("Finance and Operations", ActTitle, "Title are not equal");

            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.Module), 60);

            //Modules
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Module)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.ProjectMgmt), 60);

            // Project Management and Accounting
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ProjectMgmt)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.CollapseAll), 30);

            // Collapse All
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.CollapseAll)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.ProjectsMenu), 30);

            // Projects Menu
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ProjectsMenu)).Click();

            // All Projects 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.AllProject)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.NewButton), 30);
        }

        public void CreatePurchaseOrderThroughProjectID(FO_Reusable fO_Reusable)
        {
            // Project ID 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ProjectId)).Click();

            // Project ID 
            string ProjId = "UK600017001";
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ProjectIdFilter)).SendKeys(ProjId);

            //Apply 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ApplyFilter)).Click();

            // Manage Menu - Action page
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Manage)).Click();

            // Item Task Under Manage
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ItemTask)).Click();

            //  New Purchase Order 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.PurchaseOrder)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.VendAccount), 40);

            // Vend Account
            string VendAcc = "S000013UK60";
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.VendAccount)).SendKeys(VendAcc);

            //Default financial dimensions from the project to purchase order header?
            //Yes 
             driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Yes)).Click();

            TimeWaitsHelper.WaitForClickable(driver, By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK), 240);
            //OK Button
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK)).Click();

            //Add line 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.AddLine)).Click();

            //ProcCategory Input
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ProcCategory)).Click();

            //Expand the Procurement Category 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ProcCategoryExpand)).Click();

            //Expand Services
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Services)).Click();

            //Expand Financial Services
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.FinancialService)).Click();

            // Bank Services
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.BankServices)).Click();

            // OK Button
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK)).Click();

            // scroll - horizontal 
            IWebElement elementDrag = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.HorizontalScrollBar_InvoiceMenu));

            // Quantity 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK)).SendKeys("2");

            // Unit Price
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.UnitPrice)).SendKeys("100");

            // Save
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Save_Ok)).Click();

            // Workflow Submit
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.WorkFlow)).Click();

             String Comment = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OperationCompleted)).Text;
             Assert.AreEqual("Operation completed", Comment, "Validations are not equal");

            // Workflow Comment Submit
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Submit)).Click();
        }

    }
}
