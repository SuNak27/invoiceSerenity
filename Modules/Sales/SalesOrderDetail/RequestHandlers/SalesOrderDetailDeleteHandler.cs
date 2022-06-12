using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Sales.SalesOrderDetailRow;

namespace InvoiceKu.Sales
{
    public interface ISalesOrderDetailDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesOrderDetailDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISalesOrderDetailDeleteHandler
    {
        public SalesOrderDetailDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}