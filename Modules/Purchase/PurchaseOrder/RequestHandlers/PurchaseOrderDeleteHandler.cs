using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Purchase.PurchaseOrderRow;

namespace InvoiceKu.Purchase
{
    public interface IPurchaseOrderDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseOrderDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseOrderDeleteHandler
    {
        public PurchaseOrderDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}