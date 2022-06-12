using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Purchase.PurchaseOrderDetailRow;

namespace InvoiceKu.Purchase
{
    public interface IPurchaseOrderDetailDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseOrderDetailDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseOrderDetailDeleteHandler
    {
        public PurchaseOrderDetailDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}