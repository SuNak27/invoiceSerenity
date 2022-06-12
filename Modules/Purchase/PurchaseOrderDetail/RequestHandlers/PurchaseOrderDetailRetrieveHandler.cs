using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Purchase.PurchaseOrderDetailRow>;
using MyRow = InvoiceKu.Purchase.PurchaseOrderDetailRow;

namespace InvoiceKu.Purchase
{
    public interface IPurchaseOrderDetailRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseOrderDetailRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseOrderDetailRetrieveHandler
    {
        public PurchaseOrderDetailRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}