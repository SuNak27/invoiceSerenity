using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Sales.SalesOrderRow>;
using MyRow = InvoiceKu.Sales.SalesOrderRow;

namespace InvoiceKu.Sales
{
    public interface ISalesOrderListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesOrderListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISalesOrderListHandler
    {
        public SalesOrderListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}