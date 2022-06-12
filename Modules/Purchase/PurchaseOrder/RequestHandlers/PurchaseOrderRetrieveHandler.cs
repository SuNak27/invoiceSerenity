using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Purchase.PurchaseOrderRow>;
using MyRow = InvoiceKu.Purchase.PurchaseOrderRow;

namespace InvoiceKu.Purchase
{
    public interface IPurchaseOrderRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseOrderRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseOrderRetrieveHandler
    {
        public PurchaseOrderRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}