using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Sales.InvoiceRow;

namespace InvoiceKu.Sales
{
    public interface IInvoiceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class InvoiceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInvoiceDeleteHandler
    {
        public InvoiceDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}