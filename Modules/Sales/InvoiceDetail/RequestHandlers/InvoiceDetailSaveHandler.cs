using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Sales.InvoiceDetailRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Sales.InvoiceDetailRow;

namespace InvoiceKu.Sales
{
    public interface IInvoiceDetailSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class InvoiceDetailSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInvoiceDetailSaveHandler
    {
        public InvoiceDetailSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}