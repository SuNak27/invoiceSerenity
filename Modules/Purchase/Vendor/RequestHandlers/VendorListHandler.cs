using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Purchase.VendorRow>;
using MyRow = InvoiceKu.Purchase.VendorRow;

namespace InvoiceKu.Purchase
{
    public interface IVendorListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class VendorListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IVendorListHandler
    {
        public VendorListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}