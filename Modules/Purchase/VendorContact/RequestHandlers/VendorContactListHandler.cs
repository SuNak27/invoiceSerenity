using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Purchase.VendorContactRow>;
using MyRow = InvoiceKu.Purchase.VendorContactRow;

namespace InvoiceKu.Purchase
{
    public interface IVendorContactListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class VendorContactListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IVendorContactListHandler
    {
        public VendorContactListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}