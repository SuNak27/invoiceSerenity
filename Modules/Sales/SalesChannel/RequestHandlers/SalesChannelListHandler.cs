using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Sales.SalesChannelRow>;
using MyRow = InvoiceKu.Sales.SalesChannelRow;

namespace InvoiceKu.Sales
{
    public interface ISalesChannelListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesChannelListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISalesChannelListHandler
    {
        public SalesChannelListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}