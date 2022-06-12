using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Purchase.BillRow>;
using MyRow = InvoiceKu.Purchase.BillRow;

namespace InvoiceKu.Purchase
{
    public interface IBillListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BillListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBillListHandler
    {
        public BillListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}