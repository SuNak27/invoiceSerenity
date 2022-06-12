﻿using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace InvoiceKu.Settings.Forms
{
    [FormScript("Settings.SalesTax")]
    [BasedOnRow(typeof(SalesTaxRow), CheckNames = true)]
    public class SalesTaxForm
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double TaxRatePercentage { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertUserId { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateUserId { get; set; }
        public int TenantId { get; set; }
    }
}