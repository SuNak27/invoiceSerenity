using Serenity.Navigation;
using SalesNav = InvoiceKu.Sales.Pages;
using PurchaseNav = InvoiceKu.Purchase.Pages;
using Merchandise = InvoiceKu.Merchandise.Pages;
using SettingsNav = InvoiceKu.Settings.Pages;
using Administration = InvoiceKu.Administration.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(1000, "Sales", icon: "fa-shopping-cart")]
[assembly: NavigationLink(1100, "Sales/Sales Channel", typeof(SalesNav.SalesChannelController), icon: "fa-folder")]
[assembly: NavigationLink(1200, "Sales/Customer", typeof(SalesNav.CustomerController), icon: "fa-folder")]
[assembly: NavigationLink(1300, "Sales/Sales Order", typeof(SalesNav.SalesOrderController), icon: "fa-folder")]
[assembly: NavigationLink(1400, "Sales/Invoice", typeof(SalesNav.InvoiceController), icon: "fa-folder")]
[assembly: NavigationLink(1500, "Sales/Invoice Payment", typeof(SalesNav.InvoicePaymentController), icon: "fa-folder")]

// [assembly: NavigationLink(1500, "Sales/Custumer Contact", typeof(SalesNav.CustumerContactController), icon: "fa-folder")]
// [assembly: NavigationLink(1700, "Sales/Invoice Detail", typeof(SalesNav.InvoiceDetailController), icon: "fa-folder")]
// [assembly: NavigationLink(1800, "Sales/Sales Order Detail", typeof(SalesNav.SalesOrderDetailController), icon: "fa-folder")]

[assembly: NavigationMenu(2000, "Purchase", icon: "fa-shopping-bag")]
[assembly: NavigationLink(2100, "Purchase/Vendor", typeof(PurchaseNav.VendorController), icon: "fa-folder")]
[assembly: NavigationLink(2200, "Purchase/Purchase Order", typeof(PurchaseNav.PurchaseOrderController), icon: "fa-folder")]
[assembly: NavigationLink(2300, "Purchase/Bill", typeof(PurchaseNav.BillController), icon: "fa-folder")]
[assembly: NavigationLink(2400, "Purchase/Bill Payment", typeof(PurchaseNav.BillPaymentController), icon: "fa-folder")]

// [assembly: NavigationLink(2500, "Purchase/Bill Detail", typeof(PurchaseNav.BillDetailController), icon: "fa-folder")]
// [assembly: NavigationLink(2600, "Purchase/Purchase Order Detail", typeof(PurchaseNav.PurchaseOrderDetailController), icon: "fa-folder")]
// [assembly: NavigationLink(2700, "Purchase/Vendor Contact", typeof(PurchaseNav.VendorContactController), icon: "fa-folder")]

[assembly: NavigationMenu(3000, "Merchandise", icon: "fa-th")]
[assembly: NavigationLink(3100, "Merchandise/Uom", typeof(Merchandise.UomController), icon: "fa-folder")]
[assembly: NavigationLink(3200, "Merchandise/Size", typeof(Merchandise.SizeController), icon: "fa-folder")]
[assembly: NavigationLink(3300, "Merchandise/Colour", typeof(Merchandise.ColourController), icon: "fa-folder")]
[assembly: NavigationLink(3400, "Merchandise/Flavour", typeof(Merchandise.FlavourController), icon: "fa-folder")]
[assembly: NavigationLink(3500, "Merchandise/Brand", typeof(Merchandise.BrandController), icon: "fa-folder")]
[assembly: NavigationLink(3600, "Merchandise/Category", typeof(Merchandise.CategoryController), icon: "fa-folder")]
[assembly: NavigationLink(3700, "Merchandise/Product", typeof(Merchandise.ProductController), icon: "fa-folder")]


[assembly: NavigationMenu(4000, "Settings", icon: "fa-gear")]
[assembly: NavigationLink(4400, "Settings/My Company", typeof(SettingsNav.MyCompanyController), icon: "fa-home")]
[assembly: NavigationLink(4200, "Settings/Cash Bank", typeof(SettingsNav.CashBankController), icon: "fa-bank")]
[assembly: NavigationLink(4100, "Settings/Purchase Tax", typeof(SettingsNav.PurchaseTaxController), icon: "fa-folder")]
[assembly: NavigationLink(4300, "Settings/Sales Tax", typeof(SettingsNav.SalesTaxController), icon: "fa-folder")]