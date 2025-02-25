using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridFramework.Reusable_Functions.D365FO
{
    public class FO_ElementRef
    {
        public class FO_CommonRef
        {
            public static string CloseButtonsOnAllScreens = "//button[@name='SystemDefinedCloseButton']";
            public static string RefreshButton = "//button[@aria-label='Refresh']";
            public static string PleaseWaitBlockingMessage = "//*[@id='blockingMessage']";
            public static string ProcessingOperation = "//span[contains(text(), 'Processing operation')]";

            // Column sort
            public static string SortNewestToOldest = "//*[text() ='Sort newest to oldest']";
            public static string SortOldestToNewest = "//*[text() ='Sort oldest to newest']";
            public static string SortZToA = "//*[text() ='Sort Z to A']";
            public static string SortAToZ = "//*[text() ='Sort A to Z']";
            public static string FilterFieldTextBox = "//input[starts-with(@name,'FilterField')]";
            public static string ApplyFilterButton = "(//*[contains(@id,'ApplyFilters')])[1]";
            public static string ApplyFilterButton_2 = "//*[contains(@id,'ApplyFilters') and text() ='Apply']";
            public static string ClearFilterbutton = "(//*[contains(@id,'_ResetFilters')])[1]";

            // InsertColumns in grid
            public static string GridOptions_More = "//button[@aria-label='Grid options']";
            public static string InsertColumn_More = "//button[@id='AddNewColumnId']";
            public static string ColumnField_InsertColumnsPopup = "//div[@data-dyn-columnname='FormControlFieldSelector_Grid_Field']";
            public static string ColumnTable_InsertColumnsPopup = "//div[@data-dyn-columnname='FormControlFieldSelector_Grid_Table']";
            public static string CheckBox_InsertColumnsPopup = "//div[@aria-label='Select']//span";
            public static string OKButton_OK = "//button[@name='OK']";
            public static string OKButton_OK1 = "//button[@name='Ok']";
            public static string OKButton_OKButton = "";
            public static string OKButton_Ok_OkButton = "//button[@name='OkButton']";
            public static string LineView_header = "//li[@data-dyn-controlname='LineView_header']";
            public static string HeaderView_header = "//li[@data-dyn-controlname='HeaderView_header']";
            public static string NoButton_No = "//button[@name='No']";
            public static string CloseButton = "//button[@name='CloseButton']";
            public static string NewButton = "//span[text() ='New']";
            public static string YesButton_Yes = "//button[@name='Yes']";
            public static string HorizotalScrollBar = "//div[@class='ScrollbarLayout_face ScrollbarLayout_faceHorizontal public_Scrollbar_face']";
            public static string HorizotalScrollBar_2 = "//div[@class='public_fixedDataTable_horizontalScrollbar']";
            public static string buttonLabelViewDetails = "//span[@class='button-label' and text()='View details']";
            public static string EditButton = "//button[@name='SystemDefinedViewEditButton']";
            public static string NotificationBellButton = "//*[@data-dyn-controlname='navBarMessageCenter']";

            //public static string HorizotalScrollBar = "(//div[@class='ScrollbarLayout_face ScrollbarLayout_faceHorizontal public_Scrollbar_face'])[2]";
            //public static string HorizotalScrollBar_2 = "//div[@data-dyn-controlname='SalesLineGrid']//div[@class='ScrollbarLayout_face ScrollbarLayout_faceHorizontal public_Scrollbar_face']";
            public static string HorizotalScrollBar_3 = "//div[@class='ScrollbarLayout_face ScrollbarLayout_faceHorizontal public_Scrollbar_faceActive public_Scrollbar_face']";
            public static string HorizotalScrollBar_DetailsTab = "(//div[@class='ScrollbarLayout_face ScrollbarLayout_faceHorizontal public_Scrollbar_face'])[2]";

            //public static string buttonLabelViewDetails = "//span[@class='button-label' and text()='View details']"; //*[@aria-label='View details']
            // public static string EditButton = "//Button[contains(@id,'SystemDefinedViewEditButton')]";
            public static string CheckBox = "//span[contains(@class,'dyn-checkbox-span')]";
            public static string CheckBox2 = "//div[contains(@id,'TMVAutoAddonSelectionLine_UseMainAddonQty') and contains(@id,'container')]/div";
            public static string CheckBoxEnabled = "//*[contains(@class,'dyn-enabled')]";
            public static string CheckBoxDisabled = "//span[contains(@class,'dyn-checkbox-span')]";
            public static string QuickFilter = "//*[contains(@name,'QuickFilterControl_Input')]";
            public static string ActiveCheckBox = "//div[contains(@id,'SalesLineGrid') and contains(@id,'row-1')]//div[@title='Select or unselect row']";

            public static string CancelButton = "//*[@data-dyn-controlname='CancelButton']";

            //Bhavana
            public static string DashboardTitle = "span[id='NavBarDashboard_label']";           
            public static string Module = "//div[@aria-label='Modules']";
            public static string SalesAndMarketing = "//a[text()= 'Sales and marketing']";
            public static string SalesOrderMenu = "//a [@aria-label='Sales orders']";
            public static string AllSalesOrders = "//a [@data-dyn-title='All sales orders']";
            public static string Quantity = "//input[@aria-label='Quantity']";
            public static string UnitPrice = "//input[@aria-label='Unit price']";
            public static string NetAmount = "//input[@aria-label='Net amount']";
            public static string ItemNo = "//input[@aria-label='Item number']";
            public static string AccountReceivable = "//a[text()= 'Accounts receivable']";
            public static string Payments = "//a[@aria-label='Payments']";
            public static string CustPaym = "//div[@aria-label='Customer payment journal']";
            public static string JournalName = "//input[starts-with(@id,'JournalName_') and contains(@id,'input')]";
            public static string Lines = "//span[text() ='Lines']";
            public static string CustAccount = "//input[@aria-label='Account']";
            public static string AccountName = "//input[@aria-label='Account name']";
            public static string OffsetAccountType = "input[aria-label='Offset account type']";
            public static string OffsetAccount = "input[aria-label='BankAccount']";
            public static string MethodOfPayment = "input[aria-label='Method of payment']";
            public static string PaymentStatus = "input[aria-label='Payment status']";
            public static string ClickLastButton = "//div[@role='checkbox' and @title='Select or unselect all rows']";

            /* */
            public static string ProjectMgmt = "//a[text()='Project management and accounting']";
            
            public static string ProjectsMenu = "//a[text()= 'Projects']";
            public static string PurchaseOrder = "//span[text()= 'Purchase order']";
            public static string ProjectId = "//div[text()= 'Project ID']";
            public static string ProjectIdFilter = "//input[@aria-label='Filter field: Project ID, operator: contains']";
            public static string AddLine = "//span[text() = 'Add line']";

            public static string AllProject = "//a[text()='All projects']";
            public static string VendAccount = "//input[starts-with(@id, 'PurchCreateOrder_') and contains(@id, 'PurchTable_OrderAccount_input')]";
            public static string Manage = "//span[text()='Manage']";
            public static string ItemTask = "//span[text()='Item task']";
           // public static string ProcCategoryBtn = "(//button[@class='treeView-treeExpandCollapse'])[2]";
            public static string ProcCategory = "//input[@aria-label='Procurement category']";
            public static string ProcCategoryExpand = "//li[@data-expanded='true' and @aria-label= 'Procurement Categories (Procurement Categories (UK LE))']";
            public static string Services = "//span[@title='Services']";
           
            public static string FinancialService = "//ul/li[@aria-label='Financial Services (New category)' and @data-expanded='true']";
            public static string BankServices = "//ul/li[@aria-label='Bank services / financing (New category)' and @data-selected='true']";





            public static string Yes  = "//button[@name = 'Yes']";
            public static string WorkFlow = "//span[text()= 'Workflow']";
            public static string Submit = "//button[@name='Submit']";
            public static string LegalEntity = "//button[@name='companybutton']";
            public static string WorkFlowSubmit = "//button[@name='PromotedAction1']";

            public static string SettleTransactions = "//span[text()= 'Settle transactions']";
            public static string Invoice_CustTrans = "//input[starts-with(@id,'__FilterField_Overview_CustTrans_Invoice_Invoice_Input') and contains(@id,'_input')]";
            public static string Invoice_Filter = "(//div[text() = 'Invoice'])[2]";
            public static string ApplyFilter = "//span[text()= 'Apply']";
            public static string Save_Ok = "//button[@name='Save']";
            public static string Post = "(//button[starts-with(@id,'LedgerJournalTransCustPaym') and contains(@id,'PostJournal')])[1]";
            public static string SystemNewButton = "//span[starts-with(@id,'salestablelistpage') and contains(@id,'SystemDefinedNewButton_label')]";


            public static string NewCustomer = "//input[@name='SalesTable_CustAccount']";
            public static string Site = "//input[@name='SalesTable_InventSiteId']";
            public static string Warehouse = "//input[@name='SalesTable_InventLocationId']";
            public static string ShippingDate = "//input[@name='SalesTable_ShippingDateRequested']";
            public static string ConfirmDate_Toggle = "//span[contains(@id,'ConfirmDates_toggle')]";
            public static string CollapseAll = "//button[@class='modulesFlyout-CollapseAll']";

            // Action Pane Tabs
            public static string SellTab = "//button[starts-with(@id,'SalesTable') and contains(@id,'Sell_button')]";
            public static string ConfirmSalesOrder = "//span[text()='Confirm sales order']";
            public static string ConfirmSalesOrder_Okay = "//button[starts-with(@id,'SalesEditLines_') and contains(@id,'OK')]";

            //public static string InvoiceTab = "(//button[contains(@id,'_Invoice_button')])[2]";
            public static string InvoiceTab = "//button[starts-with(@id,'SalesTable_') and contains(@id,'_Invoice_button')]";
            
            //public static string InvoiceMenu = "//button[@name='buttonUpdateInvoice']";
            public static string InvoiceMenu = "//button[starts-with(@id,'SalesTable_') and contains(@id,'_buttonUpdateInvoice')]";

            public static string JournalInvoice = "(//button[@name='buttonJournalInvoice'])[2]";

            public static string aa = "(//div[@class='ScrollbarLayout_face ScrollbarLayout_faceHorizontal public_Scrollbar_face'])[3]";
            
            public static string HorizontalScrollBar_InvoiceMenu = "(//div[@class='ScrollbarLayout_face ScrollbarLayout_faceHorizontal public_Scrollbar_face'])[2]" ;
            public static string Lines_Invoicing = "//button[@aria-label='Lines']";
            public static string LinesDetails = "(//button[@aria-label='Line details'])[2]";
            public static string SalesOrderinInvoice = "//div[starts-with(@id,'SalesParmLine_OrigSalesId_') and contains(@Id,'_header')]";

            // success warning messages
            public static string OperationCompleted = "//span[text()= 'Operation completed']";

            // Dailog
            public static string Dailog_ConfirmSalesOrderOkay = "//button[starts-with(@id,'SysBoxForm_') and contains(@id,'Ok')]";
            public static string SalesEditLines_Quantity = "//input[starts-with(@id,'SalesEditLines') and contains(@id,'specQty_input')]";

            // Details tabs 
            public static string HeaderTab = "//li[starts-with(@id,'SalesTable_') and contains(@Id,'_HeaderView_header')]";
            public static string GeneralTab = "//button[@aria-label='General']";

            // input fields
            public static string SalesId = "//input[@name='SalesTable_SalesId']";
            public static string SalesValue = "//input[contains(@id,'CustInvoiceJour_SalesOrderNumber_Grid_') and @aria-label='Sales order']";
            public static string SalesStatus = "//inpsut[starts-with(@id,'SalesTable_') and contains(@Id,'_status_DocumentStatus_input')]";
            public static string InvoiceNo = "//input[starts-with(@id,'CustInvoiceJour_InvoiceNum_Grid_') and contains(@id,'_input')]";


        }

        public static class FO_LoginPageRef
        {
            public static string Email = "loginfmt";
            public static string Password = "//input[@type='password']";
            public static string ClickNext = "//input[@type='submit']";
            /// <summary>
            ///  Element property for EmailTextBox in login page
            /// </summary>
            public static string EmailTextBox_id = "i0116";

            /// <summary>
            ///  Element property for EmailTextBox in login page
            /// </summary>
            public static string NextButton_id = "idSIButton9";

            /// <summary>
            ///  Element property for UsernameTextBox in login page
            /// </summary>
            public static string UsernameTextBox_id = "okta-signin-username";

            /// <summary>
            ///  Element property for PasswordTextBox in login page
            /// </summary>
            public static string PasswordTextBox_xpath = "//*[@name='passwd']";

            /// <summary>
            ///  Element property for SubmitButton in login page
            /// </summary>
            public static string SubmitButton_xpath = "//input[@type='submit']";
            public static string SubmitButton = "//*[@name='SubmitButton']";
           
            public static string NavDashboardLabel_id = "NavBarDashboard_label";
            public static string Save_Name = "SystemDefinedSaveButton";
        }
    }
}
