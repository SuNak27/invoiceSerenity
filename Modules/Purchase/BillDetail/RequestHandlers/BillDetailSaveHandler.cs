using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Purchase.BillDetailRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Purchase.BillDetailRow;

namespace InvoiceKu.Purchase
{
    public interface IBillDetailSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BillDetailSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBillDetailSaveHandler
    {
        public BillDetailSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}