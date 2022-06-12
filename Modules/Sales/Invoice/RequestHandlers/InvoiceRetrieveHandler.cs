using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Sales.InvoiceRow>;
using MyRow = InvoiceKu.Sales.InvoiceRow;

namespace InvoiceKu.Sales
{
    public interface IInvoiceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class InvoiceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInvoiceRetrieveHandler
    {
        public InvoiceRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}