using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Purchase.PurchaseOrderDetailRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Purchase.PurchaseOrderDetailRow;

namespace InvoiceKu.Purchase
{
    public interface IPurchaseOrderDetailSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseOrderDetailSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseOrderDetailSaveHandler
    {
        public PurchaseOrderDetailSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}