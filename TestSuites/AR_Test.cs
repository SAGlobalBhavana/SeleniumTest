using HybridFramework.ComonUtilities;
using HybridFramework.Reusable_Functions.D365FO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFramework.TestSuites
{
    [TestClass]
    public class AR_Test :TestBase
    {
        FO_ARPages ARPage = new FO_ARPages();
        FO_LoginPage loginPage = new FO_LoginPage();
        FO_Reusable fO_Reusable = new FO_Reusable();

        [ClassInitialize]
       
        public static void LoginPart(TestContext context)
        {
            FO_LoginPage.loginFO(FO_URL, FO_Username, FO_Password);
        }

        [TestMethod]
        [TestCategory("Sales Order Workflow")]
        public void CreateSalesOrder_Confirm_Invoice()
        {                       
            // Navigating to All sales order page
            ARPage.NavigateToAllSalesOrderPage();

            // Create new Sales Order 
            ARPage.CreateSO(fO_Reusable);

            // Confirmation of Sales Order
            string salesOrder =  ARPage.ConfirmingSO(fO_Reusable);

            // Invoicing the Sales Order
            string InvoiceNumber = ARPage.InvoiceSO(salesOrder, fO_Reusable);

            // navigate to Customer journal
          //  ARPage.NavigateToCustJournal(fO_Reusable);

            // Post Payment journal
          //  ARPage.CreatePostPaymentJournal(fO_Reusable, InvoiceNumber);
        }
       
    }
}
