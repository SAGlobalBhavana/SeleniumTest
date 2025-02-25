using EmpowerApps.SeleniumUtility;
using HybridFramework.ComonUtilities;
using HybridFramework.Reusable_Functions.D365FO;
using HybridFramework.SeleniumUtility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace HybridFramework.TestSuites
{
    [TestClass]
  public class OCSPractice : TestBase
    {
        FO_PurchaseOrderPage fO_Purchase = new FO_PurchaseOrderPage();
        FO_Reusable fO_Reusable = new FO_Reusable();

        [ClassInitialize]

        public static void LoginPart(TestContext context)
        {
            FO_LoginPage.loginFO(FO_URL, FO_Username, FO_Password);
        }

        [TestMethod]

        public void PurchaseOrder_Workflow()
        {
            // login to Legal Entity - UK10
            fO_Purchase.NavigateToUKEntity();
            // Navigating to All projects 
            fO_Purchase.NavigateToAllProjects();

            // Create new Purchase Order 
            fO_Purchase.CreatePurchaseOrderThroughProjectID(fO_Reusable);
        }
    }
}

