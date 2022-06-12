using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Purchase.BillRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Purchase.BillRow;

namespace InvoiceKu.Purchase
{
    public interface IBillSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BillSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBillSaveHandler
    {
        public BillSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}