using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace InvoiceKu.Sales
{
    public partial class CustomerContactEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "InvoiceKu.Sales.CustomerContactEditor";

        public CustomerContactEditorAttribute()
            : base(Key)
        {
        }
    }
}
