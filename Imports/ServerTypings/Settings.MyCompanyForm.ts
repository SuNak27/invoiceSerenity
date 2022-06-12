namespace InvoiceKu.Settings {
    export interface MyCompanyForm {
        TenantName: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Currency: Serenity.StringEditor;
        Street: Serenity.StringEditor;
        City: Serenity.StringEditor;
        State: Serenity.StringEditor;
        ZipCode: Serenity.StringEditor;
        Phone: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        MaximumUser: Serenity.IntegerEditor;
        ProductNumberPrefix: Serenity.StringEditor;
        ProductNumberUseDate: Serenity.StringEditor;
        ProductNumberLength: Serenity.IntegerEditor;
        CustomerNumberPrefix: Serenity.StringEditor;
        CustomerNumberUseDate: Serenity.StringEditor;
        CustomerNumberLength: Serenity.IntegerEditor;
        SalesNumberPrefix: Serenity.StringEditor;
        SalesNumberUseDate: Serenity.StringEditor;
        SalesNumberLength: Serenity.IntegerEditor;
        InvoiceNumberPrefix: Serenity.StringEditor;
        InvoiceNumberUseDate: Serenity.StringEditor;
        InvoiceNumberLength: Serenity.IntegerEditor;
        InvoicePaymentNumberPrefix: Serenity.StringEditor;
        InvoicePaymentNumberUseDate: Serenity.StringEditor;
        InvoicePaymentNumberLength: Serenity.IntegerEditor;
        VendorNumberPrefix: Serenity.StringEditor;
        VendorNumberUseDate: Serenity.StringEditor;
        VendorNumberLength: Serenity.StringEditor;
        PurchaseNumberPrefix: Serenity.StringEditor;
        PurchaseNumberUseDate: Serenity.StringEditor;
        PurchaseNumberLength: Serenity.IntegerEditor;
        BillNumberPrefix: Serenity.StringEditor;
        BillNumberUseDate: Serenity.StringEditor;
        BillNumberLength: Serenity.IntegerEditor;
        BillPaymentNumberPrefix: Serenity.StringEditor;
        BillPaymentNumberUseDate: Serenity.StringEditor;
        BillPaymentNumberLength: Serenity.IntegerEditor;
    }

    export class MyCompanyForm extends Serenity.PrefixedContext {
        static formKey = 'Settings.MyCompany';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MyCompanyForm.init)  {
                MyCompanyForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;

                Q.initFormType(MyCompanyForm, [
                    'TenantName', w0,
                    'Description', w0,
                    'Currency', w0,
                    'Street', w0,
                    'City', w0,
                    'State', w0,
                    'ZipCode', w0,
                    'Phone', w0,
                    'Email', w0,
                    'MaximumUser', w1,
                    'ProductNumberPrefix', w0,
                    'ProductNumberUseDate', w0,
                    'ProductNumberLength', w1,
                    'CustomerNumberPrefix', w0,
                    'CustomerNumberUseDate', w0,
                    'CustomerNumberLength', w1,
                    'SalesNumberPrefix', w0,
                    'SalesNumberUseDate', w0,
                    'SalesNumberLength', w1,
                    'InvoiceNumberPrefix', w0,
                    'InvoiceNumberUseDate', w0,
                    'InvoiceNumberLength', w1,
                    'InvoicePaymentNumberPrefix', w0,
                    'InvoicePaymentNumberUseDate', w0,
                    'InvoicePaymentNumberLength', w1,
                    'VendorNumberPrefix', w0,
                    'VendorNumberUseDate', w0,
                    'VendorNumberLength', w0,
                    'PurchaseNumberPrefix', w0,
                    'PurchaseNumberUseDate', w0,
                    'PurchaseNumberLength', w1,
                    'BillNumberPrefix', w0,
                    'BillNumberUseDate', w0,
                    'BillNumberLength', w1,
                    'BillPaymentNumberPrefix', w0,
                    'BillPaymentNumberUseDate', w0,
                    'BillPaymentNumberLength', w1
                ]);
            }
        }
    }
}
