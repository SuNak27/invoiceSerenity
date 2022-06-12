using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Purchase.BillRow>;
using MyRow = InvoiceKu.Purchase.BillRow;

namespace InvoiceKu.Purchase
{
    public interface IBillRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BillRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBillRetrieveHandler
    {
        public BillRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}