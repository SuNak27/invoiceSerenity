using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Sales.SalesOrderRow>;
using MyRow = InvoiceKu.Sales.SalesOrderRow;

namespace InvoiceKu.Sales
{
    public interface ISalesOrderRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesOrderRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesOrderRetrieveHandler
    {
        public SalesOrderRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}