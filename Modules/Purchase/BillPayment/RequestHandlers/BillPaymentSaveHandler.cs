using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Purchase.BillPaymentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Purchase.BillPaymentRow;

namespace InvoiceKu.Purchase
{
    public interface IBillPaymentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BillPaymentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBillPaymentSaveHandler
    {
        public BillPaymentSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}