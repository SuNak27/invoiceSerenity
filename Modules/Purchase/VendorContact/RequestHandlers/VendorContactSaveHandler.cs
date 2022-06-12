using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Purchase.VendorContactRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Purchase.VendorContactRow;

namespace InvoiceKu.Purchase
{
    public interface IVendorContactSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class VendorContactSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IVendorContactSaveHandler
    {
        public VendorContactSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}