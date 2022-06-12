using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Purchase.PurchaseOrderRow>;
using MyRow = InvoiceKu.Purchase.PurchaseOrderRow;

namespace InvoiceKu.Purchase
{
    public interface IPurchaseOrderListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseOrderListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseOrderListHandler
    {
        public PurchaseOrderListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}