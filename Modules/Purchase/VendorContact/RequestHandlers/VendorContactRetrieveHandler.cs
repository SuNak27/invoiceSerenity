using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Purchase.VendorContactRow>;
using MyRow = InvoiceKu.Purchase.VendorContactRow;

namespace InvoiceKu.Purchase
{
    public interface IVendorContactRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class VendorContactRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IVendorContactRetrieveHandler
    {
        public VendorContactRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}