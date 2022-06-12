using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Sales.InvoiceDetailRow>;
using MyRow = InvoiceKu.Sales.InvoiceDetailRow;

namespace InvoiceKu.Sales
{
    public interface IInvoiceDetailRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class InvoiceDetailRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInvoiceDetailRetrieveHandler
    {
        public InvoiceDetailRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}