using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Purchase.PurchaseOrderRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Purchase.PurchaseOrderRow;

namespace InvoiceKu.Purchase
{
    public interface IPurchaseOrderSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseOrderSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseOrderSaveHandler
    {
        public PurchaseOrderSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}