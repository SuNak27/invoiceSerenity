using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace InvoiceKu.Sales
{
    public partial class InvoicePaymentEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "InvoiceKu.Sales.InvoicePaymentEditor";

        public InvoicePaymentEditorAttribute()
            : base(Key)
        {
        }
    }
}
