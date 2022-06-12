using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Settings.SalesTaxRow>;
using MyRow = InvoiceKu.Settings.SalesTaxRow;

namespace InvoiceKu.Settings
{
    public interface ISalesTaxRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesTaxRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesTaxRetrieveHandler
    {
        public SalesTaxRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}