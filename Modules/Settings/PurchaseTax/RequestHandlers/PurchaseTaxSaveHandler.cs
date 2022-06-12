using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Settings.PurchaseTaxRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Settings.PurchaseTaxRow;

namespace InvoiceKu.Settings
{
    public interface IPurchaseTaxSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseTaxSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseTaxSaveHandler
    {
        public PurchaseTaxSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}