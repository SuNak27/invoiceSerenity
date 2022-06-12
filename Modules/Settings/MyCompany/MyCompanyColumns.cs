using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace InvoiceKu.Settings.Columns
{
    [ColumnsScript("Settings.MyCompany")]
    [BasedOnRow(typeof(MyCompanyRow), CheckNames = true)]
    public class MyCompanyColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int TenantId { get; set; }
        [EditLink]
        public string TenantName { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int MaximumUser { get; set; }
        public string ProductNumberPrefix { get; set; }
        public string ProductNumberUseDate { get; set; }
        public int ProductNumberLength { get; set; }
        public string CustomerNumberPrefix { get; set; }
        public string CustomerNumberUseDate { get; set; }
        public int CustomerNumberLength { get; set; }
        public string SalesNumberPrefix { get; set; }
        public string SalesNumberUseDate { get; set; }
        public int SalesNumberLength { get; set; }
        public string InvoiceNumberPrefix { get; set; }
        public string InvoiceNumberUseDate { get; set; }
        public int InvoiceNumberLength { get; set; }
        public string InvoicePaymentNumberPrefix { get; set; }
        public string InvoicePaymentNumberUseDate { get; set; }
        public int InvoicePaymentNumberLength { get; set; }
        public string VendorNumberPrefix { get; set; }
        public string VendorNumberUseDate { get; set; }
        public string VendorNumberLength { get; set; }
        public string PurchaseNumberPrefix { get; set; }
        public string PurchaseNumberUseDate { get; set; }
        public int PurchaseNumberLength { get; set; }
        public string BillNumberPrefix { get; set; }
        public string BillNumberUseDate { get; set; }
        public int BillNumberLength { get; set; }
        public string BillPaymentNumberPrefix { get; set; }
        public string BillPaymentNumberUseDate { get; set; }
        public int BillPaymentNumberLength { get; set; }
    }
}