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
    public class FO_ARPages :TestBase
    {           
        public void NavigateToAllSalesOrderPage()
        {

            string ActTitle = driver.FindElement(By.CssSelector(FO_ElementRef.FO_CommonRef.DashboardTitle)).Text;
            Assert.IsTrue(ActTitle.Contains("Finance"), "values are not matching");
            Assert.AreEqual("Finance and Operations", ActTitle, "Title are not equal");

            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.Module), 60);

            //modules
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Module)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.SalesAndMarketing), 60);           

            // Sales and marketing
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SalesAndMarketing)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.CollapseAll), 30);
           
            // Collapse All
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.CollapseAll)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.SalesOrderMenu), 30);
          
            // sales order Menu
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SalesOrderMenu)).Click();

            // All Sales Order 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.AllSalesOrders)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.NewButton),30);
        }


       

        

        public void CreateSO(FO_Reusable fO_Reusable)
        {
            //New
            fO_Reusable.ClickNewButton();              
             TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.NewCustomer), 30);

            // New SO - Cust account field 
            string cust = "000004";
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.NewCustomer)).SendKeys(cust);
            
            // Site Field
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Site)).SendKeys("1");

            // Warehouse Field 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Warehouse)).SendKeys("11" + Keys.Tab);

            // Date Button
            DateTime date = DateTime.Now;
            DateTime date2 = date.AddDays(2);
            var Newdate = date2.ToString("M/d/yyyy");

            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ShippingDate)).Clear();
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ShippingDate)).SendKeys(Newdate);
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.ConfirmDate_Toggle), 40);

            // Toggle button 
            string getText = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ConfirmDate_Toggle)).GetAttribute("aria-checked");
            if (getText != "true")
            {
                driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ConfirmDate_Toggle)).Click();
            }
            TimeWaitsHelper.WaitForClickable(driver, By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK), 240);

            // Okay Button
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK)).Click();
        }
       
        public string ConfirmingSO(FO_Reusable fO_Reusable)
        {           
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.ItemNo), 80);
            // input for Item field
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ItemNo)).SendKeys("A0001");
            string ItemValue =  driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ItemNo)).Text;
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.Quantity), 20);

            // input for Quantity
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Quantity)).SendKeys("2.00");

            IWebElement elementDrag = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.HorizotalScrollBar_DetailsTab));
            ActionsHelper.DragAndDropByPix(driver, elementDrag, 300);

            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.UnitPrice), 120);
            // WebElementHelper.Click_Clear_Send_Tab(driver,By.XPath(FO_ElementRef.FO_CommonRef.UnitPrice),"100.00");

            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.UnitPrice)).SendKeys("10.00" + Keys.Tab);
            
            string netAmount =  driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.NetAmount)).GetAttribute("title");

            // save button
            fO_Reusable.ClickSaveButton();  
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.SellTab), 120);
            
            //Sell Tab
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SellTab)).Click();                    
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.ConfirmSalesOrder), 30);

            //Confirm sales order button
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ConfirmSalesOrder)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.ConfirmSalesOrder_Okay), 20);

            // Confirm Sales order dailog okay button
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ConfirmSalesOrder_Okay)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.Dailog_ConfirmSalesOrderOkay), 40);

            // pop up - confirming the Okay button in pop up dailog
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Dailog_ConfirmSalesOrderOkay)).Click();
            // wait for pop up to be cleared.
            FO_Reusable.waitForProcessOperationToBeCleared(120);  
            
            // Header tab
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.HeaderTab)).Click();          
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.GeneralTab), 40);

            //General            
            fO_Reusable.ExpandTab(FO_ElementRef.FO_CommonRef.GeneralTab);
           
            // Sales Order no. in Header 
            IWebElement SalesOrderField = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SalesId));
            JSExecutorHelper.scrollByVisibleWebElement(driver, SalesOrderField);
           
            // Fetching the Sales order no.
           string salesOrderValue = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SalesId)).GetAttribute("value");

            //confirmating the sales order 
            string confirm = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SalesStatus)).GetAttribute("title");
            Assert.AreEqual("Confirmation", confirm, "Status is not confirmed");
           
            return salesOrderValue;
        }


        public string InvoiceSO(string _salesId,FO_Reusable fO_Reusable)
        {            
            // Invoice Tab
            IWebElement InvoiceTabElement = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.InvoiceTab));
            JSExecutorHelper.scrollByVisibleWebElement(driver, InvoiceTabElement);

            
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.InvoiceTab)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.InvoiceMenu), 120);

            // Invoice menu button
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.InvoiceMenu)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.SalesEditLines_Quantity), 60);

            // Quantity - All 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SalesEditLines_Quantity)).Clear();
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SalesEditLines_Quantity)).SendKeys("All" + Keys.Tab);

            //lines
            fO_Reusable.ExpandTab(FO_ElementRef.FO_CommonRef.Lines_Invoicing);
           
           // TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.HorizontalScrollBar_InvoiceMenu), 120);

            IWebElement Sales_Invoice = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SalesOrderinInvoice));
            JSExecutorHelper.scrollByVisibleWebElement(driver, Sales_Invoice);
           // TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.HorizontalScrollBar_InvoiceMenu), 240);

            // scroll - horizontal 
            IWebElement elementDrag = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.HorizontalScrollBar_InvoiceMenu));
           
            ActionsHelper.DragAndDropByPix(driver, elementDrag, 200);
           //JSExecutorHelper.scrollToRightByPixels(driver, 200, driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.HorizontalScrollBar_InvoiceMenu)));

            // validate the Item No. 
            string  ItemValue = "A0001";
            string ItemVal = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ItemNo)).GetAttribute("value");
            Assert.AreEqual(ItemValue, ItemVal, "Item is not matching");
         
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK), 120);

            // Ok button 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK1), 120);

            // Dailog Ok button 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OKButton_OK1)).Click();

            string validateOperationCompleted = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OperationCompleted)).Text;
            Assert.AreEqual("Operation completed", validateOperationCompleted, "Validation - Operation completed failed");
            FO_Reusable.waitForProcessOperationToBeCleared(120);
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.InvoiceTab), 60);
            
            //Again Invoice Tab
            IWebElement invoiceTab = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.InvoiceTab));
             JSExecutorHelper.scrollByVisibleWebElement(driver, invoiceTab);

             driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.InvoiceTab)).Click();
           
            //Journal - Invoice Menu 
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.JournalInvoice), 120);
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.JournalInvoice)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.SalesValue), 240);

            // validate the value Sales Order           
            string salesOrderValue = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SalesValue)).GetAttribute("value");
            Assert.AreEqual(_salesId, salesOrderValue, "Sales Id is not valid");

            // Fetch the value Invoice No.
             string InvoiceNo = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.InvoiceNo)).GetAttribute("title");            

            return InvoiceNo;
        }

        public void NavigateToCustJournal(FO_Reusable fO_Reusable)
        {
            string ActTitle = driver.FindElement(By.CssSelector(FO_ElementRef.FO_CommonRef.DashboardTitle)).Text;
            Assert.IsTrue(ActTitle.Contains("Finance"), "values are not matching");
            Assert.AreEqual("Finance and Operations", ActTitle, "Title are not equal");

            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.Module), 60);

            //modules
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Module)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.AccountReceivable), 60);

            // Account Receivable
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.AccountReceivable)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.CollapseAll), 30);

            // Collapse All
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.CollapseAll)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.Payments), 30);
           
            fO_Reusable.ExpandTab(FO_ElementRef.FO_CommonRef.Payments);
            // Payments
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.CustPaym)).Click();

        }
        public void CreatePostPaymentJournal(FO_Reusable fO_Reusable, String InvoiceNum)
        {
            //New
            fO_Reusable.ClickNewButton();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.JournalName), 60);
            // Journal Name 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.JournalName)).SendKeys("CustPay" + Keys.Tab);
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.Lines), 120);

            // Lines Menu
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Lines)).Click();
            Thread.Sleep(8000);
           // TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.CustAccount), 360);
            // Account Value
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.CustAccount)).SendKeys("000004" + Keys.Tab);

            // Account Name 
           string accountName =  driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.AccountName)).GetAttribute("title");
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.SettleTransactions), 120);

            //Settle Transaction Menu
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.SettleTransactions)).Click();
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.Invoice_Filter), 60);
            // Click on Invoice
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Invoice_Filter)).Click();

            // Filter the Invoice 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Invoice_CustTrans)).SendKeys(InvoiceNum);
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.ApplyFilterButton_2), 60);

            // apply button         
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.ApplyFilterButton_2)).Click();
            Thread.Sleep(6000); 

            // mark the record
           // fO_Reusable.ClickLastButton(FO_ElementRef.FO_CommonRef.ClickLastButton);
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.Save_Ok), 120);

            // Okay 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Save_Ok)).Click();
          // TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.HorizontalScrollBar_InvoiceMenu), 60);
 
            // horizontal scroll 
            //IWebElement elementDrag = driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.HorizontalScrollBar_InvoiceMenu));           
            //ActionsHelper.DragAndDropByPix(driver, elementDrag, 300);

            // Input values 
            // Offset Account type 
            TimeWaitsHelper.WaitForVisible(driver, By.XPath(FO_ElementRef.FO_CommonRef.OffsetAccountType), 120);

            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OffsetAccountType)).SendKeys("Bank");
            // Offset Account
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.OffsetAccount)).SendKeys("USMF OPER");

            // Method of Payment
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.MethodOfPayment)).SendKeys("CASH");

            // Payment Status 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.PaymentStatus)).SendKeys("Sent");

            // Post 
            driver.FindElement(By.XPath(FO_ElementRef.FO_CommonRef.Post)).Click();


        }

    }
}
