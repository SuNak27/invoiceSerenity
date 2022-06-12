using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Purchase.PurchaseOrderDetailRow>;
using MyRow = InvoiceKu.Purchase.PurchaseOrderDetailRow;

namespace InvoiceKu.Purchase
{
    public interface IPurchaseOrderDetailListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseOrderDetailListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseOrderDetailListHandler
    {
        public PurchaseOrderDetailListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}