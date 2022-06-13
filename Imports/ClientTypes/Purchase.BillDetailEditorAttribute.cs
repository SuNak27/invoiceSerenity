using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace InvoiceKu.Purchase
{
    public partial class BillDetailEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "InvoiceKu.Purchase.BillDetailEditor";

        public BillDetailEditorAttribute()
            : base(Key)
        {
        }
    }
}
