using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Sales.InvoiceRow>;
using MyRow = InvoiceKu.Sales.InvoiceRow;

namespace InvoiceKu.Sales
{
    public interface IInvoiceListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class InvoiceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInvoiceListHandler
    {
        public InvoiceListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}