using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace InvoiceKu.Sales
{
    public partial class InvoiceEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "InvoiceKu.Sales.InvoiceEditor";

        public InvoiceEditorAttribute()
            : base(Key)
        {
        }
    }
}
