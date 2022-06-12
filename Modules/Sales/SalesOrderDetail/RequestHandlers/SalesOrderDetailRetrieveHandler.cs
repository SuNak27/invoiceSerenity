using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Sales.SalesOrderDetailRow>;
using MyRow = InvoiceKu.Sales.SalesOrderDetailRow;

namespace InvoiceKu.Sales
{
    public interface ISalesOrderDetailRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesOrderDetailRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesOrderDetailRetrieveHandler
    {
        public SalesOrderDetailRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}