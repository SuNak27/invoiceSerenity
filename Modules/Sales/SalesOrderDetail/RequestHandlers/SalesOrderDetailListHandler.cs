using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Sales.SalesOrderDetailRow>;
using MyRow = InvoiceKu.Sales.SalesOrderDetailRow;

namespace InvoiceKu.Sales
{
    public interface ISalesOrderDetailListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesOrderDetailListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISalesOrderDetailListHandler
    {
        public SalesOrderDetailListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}