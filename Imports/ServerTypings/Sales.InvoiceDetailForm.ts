namespace InvoiceKu.Sales {
    export interface InvoiceDetailForm {
        InvoiceId: Serenity.IntegerEditor;
        ProductId: Serenity.LookupEditor;
        Price: Serenity.DecimalEditor;
        Qty: Serenity.DecimalEditor;
        SubTotal: Serenity.DecimalEditor;
        Discount: Serenity.DecimalEditor;
        BeforeTax: Serenity.DecimalEditor;
        TaxPercentage: Serenity.DecimalEditor;
        TaxAmount: Serenity.DecimalEditor;
        Total: Serenity.DecimalEditor;
        InsertDate: Serenity.DateEditor;
        InsertUserId: Serenity.IntegerEditor;
        UpdateDate: Serenity.DateEditor;
        UpdateUserId: Serenity.IntegerEditor;
        TenantId: Serenity.IntegerEditor;
    }

    export class InvoiceDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.InvoiceDetail';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!InvoiceDetailForm.init)  {
                InvoiceDetailForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.LookupEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.DateEditor;

                Q.initFormType(InvoiceDetailForm, [
                    'InvoiceId', w0,
                    'ProductId', w1,
                    'Price', w2,
                    'Qty', w2,
                    'SubTotal', w2,
                    'Discount', w2,
                    'BeforeTax', w2,
                    'TaxPercentage', w2,
                    'TaxAmount', w2,
                    'Total', w2,
                    'InsertDate', w3,
                    'InsertUserId', w0,
                    'UpdateDate', w3,
                    'UpdateUserId', w0,
                    'TenantId', w0
                ]);
            }
        }
    }
}
