using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace InvoiceKu.Purchase
{
    public partial class BillEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "InvoiceKu.Purchase.BillEditor";

        public BillEditorAttribute()
            : base(Key)
        {
        }
    }
}
