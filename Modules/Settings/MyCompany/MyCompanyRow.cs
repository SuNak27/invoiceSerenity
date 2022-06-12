using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace InvoiceKu.Settings
{
    [ConnectionKey("Default"), Module("Settings"), TableName("mycompany")]
    [DisplayName("My Company"), InstanceName("My Company")]
    [ReadPermission("Settings:MyCompany")]
    [ModifyPermission("Settings:MyCompany")]
    public sealed class MyCompanyRow : Row<MyCompanyRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Tenant Id"), Identity, IdProperty]
        public int? TenantId
        {
            get => fields.TenantId[this];
            set => fields.TenantId[this] = value;
        }

        [DisplayName("Tenant Name"), Size(50), QuickSearch, NameProperty]
        public string TenantName
        {
            get => fields.TenantName[this];
            set => fields.TenantName[this] = value;
        }

        [DisplayName("Description"), Size(50), NotNull]
        public string Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Currency"), Size(50), NotNull]
        public string Currency
        {
            get => fields.Currency[this];
            set => fields.Currency[this] = value;
        }

        [DisplayName("Street"), Size(100), NotNull]
        public string Street
        {
            get => fields.Street[this];
            set => fields.Street[this] = value;
        }

        [DisplayName("City"), Size(100), NotNull]
        public string City
        {
            get => fields.City[this];
            set => fields.City[this] = value;
        }

        [DisplayName("State"), Size(100), NotNull]
        public string State
        {
            get => fields.State[this];
            set => fields.State[this] = value;
        }

        [DisplayName("Zip Code"), Size(50), NotNull]
        public string ZipCode
        {
            get => fields.ZipCode[this];
            set => fields.ZipCode[this] = value;
        }

        [DisplayName("Phone"), Size(50), NotNull]
        public string Phone
        {
            get => fields.Phone[this];
            set => fields.Phone[this] = value;
        }

        [DisplayName("Email"), Size(50), NotNull]
        public string Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        [DisplayName("Maximum User"), NotNull]
        public int? MaximumUser
        {
            get => fields.MaximumUser[this];
            set => fields.MaximumUser[this] = value;
        }

        [DisplayName("Product Number Prefix"), Size(50)]
        public string ProductNumberPrefix
        {
            get => fields.ProductNumberPrefix[this];
            set => fields.ProductNumberPrefix[this] = value;
        }

        [DisplayName("Product Number Use Date"), Size(50)]
        public string ProductNumberUseDate
        {
            get => fields.ProductNumberUseDate[this];
            set => fields.ProductNumberUseDate[this] = value;
        }

        [DisplayName("Product Number Length")]
        public int? ProductNumberLength
        {
            get => fields.ProductNumberLength[this];
            set => fields.ProductNumberLength[this] = value;
        }

        [DisplayName("Customer Number Prefix"), Size(50)]
        public string CustomerNumberPrefix
        {
            get => fields.CustomerNumberPrefix[this];
            set => fields.CustomerNumberPrefix[this] = value;
        }

        [DisplayName("Customer Number Use Date"), Size(50)]
        public string CustomerNumberUseDate
        {
            get => fields.CustomerNumberUseDate[this];
            set => fields.CustomerNumberUseDate[this] = value;
        }

        [DisplayName("Customer Number Length")]
        public int? CustomerNumberLength
        {
            get => fields.CustomerNumberLength[this];
            set => fields.CustomerNumberLength[this] = value;
        }

        [DisplayName("Sales Number Prefix"), Size(50)]
        public string SalesNumberPrefix
        {
            get => fields.SalesNumberPrefix[this];
            set => fields.SalesNumberPrefix[this] = value;
        }

        [DisplayName("Sales Number Use Date"), Size(50)]
        public string SalesNumberUseDate
        {
            get => fields.SalesNumberUseDate[this];
            set => fields.SalesNumberUseDate[this] = value;
        }

        [DisplayName("Sales Number Length")]
        public int? SalesNumberLength
        {
            get => fields.SalesNumberLength[this];
            set => fields.SalesNumberLength[this] = value;
        }

        [DisplayName("Invoice Number Prefix"), Size(50)]
        public string InvoiceNumberPrefix
        {
            get => fields.InvoiceNumberPrefix[this];
            set => fields.InvoiceNumberPrefix[this] = value;
        }

        [DisplayName("Invoice Number Use Date"), Size(50)]
        public string InvoiceNumberUseDate
        {
            get => fields.InvoiceNumberUseDate[this];
            set => fields.InvoiceNumberUseDate[this] = value;
        }

        [DisplayName("Invoice Number Length")]
        public int? InvoiceNumberLength
        {
            get => fields.InvoiceNumberLength[this];
            set => fields.InvoiceNumberLength[this] = value;
        }

        [DisplayName("Invoice Payment Number Prefix"), Size(50)]
        public string InvoicePaymentNumberPrefix
        {
            get => fields.InvoicePaymentNumberPrefix[this];
            set => fields.InvoicePaymentNumberPrefix[this] = value;
        }

        [DisplayName("Invoice Payment Number Use Date"), Size(50)]
        public string InvoicePaymentNumberUseDate
        {
            get => fields.InvoicePaymentNumberUseDate[this];
            set => fields.InvoicePaymentNumberUseDate[this] = value;
        }

        [DisplayName("Invoice Payment Number Length")]
        public int? InvoicePaymentNumberLength
        {
            get => fields.InvoicePaymentNumberLength[this];
            set => fields.InvoicePaymentNumberLength[this] = value;
        }

        [DisplayName("Vendor Number Prefix"), Size(50)]
        public string VendorNumberPrefix
        {
            get => fields.VendorNumberPrefix[this];
            set => fields.VendorNumberPrefix[this] = value;
        }

        [DisplayName("Vendor Number Use Date"), Size(50)]
        public string VendorNumberUseDate
        {
            get => fields.VendorNumberUseDate[this];
            set => fields.VendorNumberUseDate[this] = value;
        }

        [DisplayName("Vendor Number Length"), Size(50)]
        public string VendorNumberLength
        {
            get => fields.VendorNumberLength[this];
            set => fields.VendorNumberLength[this] = value;
        }

        [DisplayName("Purchase Number Prefix"), Size(50)]
        public string PurchaseNumberPrefix
        {
            get => fields.PurchaseNumberPrefix[this];
            set => fields.PurchaseNumberPrefix[this] = value;
        }

        [DisplayName("Purchase Number Use Date"), Size(50)]
        public string PurchaseNumberUseDate
        {
            get => fields.PurchaseNumberUseDate[this];
            set => fields.PurchaseNumberUseDate[this] = value;
        }

        [DisplayName("Purchase Number Length")]
        public int? PurchaseNumberLength
        {
            get => fields.PurchaseNumberLength[this];
            set => fields.PurchaseNumberLength[this] = value;
        }

        [DisplayName("Bill Number Prefix"), Size(50)]
        public string BillNumberPrefix
        {
            get => fields.BillNumberPrefix[this];
            set => fields.BillNumberPrefix[this] = value;
        }

        [DisplayName("Bill Number Use Date"), Size(50)]
        public string BillNumberUseDate
        {
            get => fields.BillNumberUseDate[this];
            set => fields.BillNumberUseDate[this] = value;
        }

        [DisplayName("Bill Number Length")]
        public int? BillNumberLength
        {
            get => fields.BillNumberLength[this];
            set => fields.BillNumberLength[this] = value;
        }

        [DisplayName("Bill Payment Number Prefix"), Size(50)]
        public string BillPaymentNumberPrefix
        {
            get => fields.BillPaymentNumberPrefix[this];
            set => fields.BillPaymentNumberPrefix[this] = value;
        }

        [DisplayName("Bill Payment Number Use Date"), Size(50)]
        public string BillPaymentNumberUseDate
        {
            get => fields.BillPaymentNumberUseDate[this];
            set => fields.BillPaymentNumberUseDate[this] = value;
        }

        [DisplayName("Bill Payment Number Length")]
        public int? BillPaymentNumberLength
        {
            get => fields.BillPaymentNumberLength[this];
            set => fields.BillPaymentNumberLength[this] = value;
        }

        public MyCompanyRow()
            : base()
        {
        }

        public MyCompanyRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field TenantId;
            public StringField TenantName;
            public StringField Description;
            public StringField Currency;
            public StringField Street;
            public StringField City;
            public StringField State;
            public StringField ZipCode;
            public StringField Phone;
            public StringField Email;
            public Int32Field MaximumUser;
            public StringField ProductNumberPrefix;
            public StringField ProductNumberUseDate;
            public Int32Field ProductNumberLength;
            public StringField CustomerNumberPrefix;
            public StringField CustomerNumberUseDate;
            public Int32Field CustomerNumberLength;
            public StringField SalesNumberPrefix;
            public StringField SalesNumberUseDate;
            public Int32Field SalesNumberLength;
            public StringField InvoiceNumberPrefix;
            public StringField InvoiceNumberUseDate;
            public Int32Field InvoiceNumberLength;
            public StringField InvoicePaymentNumberPrefix;
            public StringField InvoicePaymentNumberUseDate;
            public Int32Field InvoicePaymentNumberLength;
            public StringField VendorNumberPrefix;
            public StringField VendorNumberUseDate;
            public StringField VendorNumberLength;
            public StringField PurchaseNumberPrefix;
            public StringField PurchaseNumberUseDate;
            public Int32Field PurchaseNumberLength;
            public StringField BillNumberPrefix;
            public StringField BillNumberUseDate;
            public Int32Field BillNumberLength;
            public StringField BillPaymentNumberPrefix;
            public StringField BillPaymentNumberUseDate;
            public Int32Field BillPaymentNumberLength;
        }
    }
}
