using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Purchase.BillDetailRow>;
using MyRow = InvoiceKu.Purchase.BillDetailRow;

namespace InvoiceKu.Purchase
{
    public interface IBillDetailListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BillDetailListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBillDetailListHandler
    {
        public BillDetailListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}