using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Sales.SalesOrderRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Sales.SalesOrderRow;

namespace InvoiceKu.Sales
{
    public interface ISalesOrderSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesOrderSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesOrderSaveHandler
    {
        public SalesOrderSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}