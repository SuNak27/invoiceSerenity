using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Sales.InvoicePaymentRow>;
using MyRow = InvoiceKu.Sales.InvoicePaymentRow;

namespace InvoiceKu.Sales
{
    public interface IInvoicePaymentListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class InvoicePaymentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInvoicePaymentListHandler
    {
        public InvoicePaymentListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}