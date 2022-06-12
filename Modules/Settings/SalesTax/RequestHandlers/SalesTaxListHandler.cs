using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Settings.SalesTaxRow>;
using MyRow = InvoiceKu.Settings.SalesTaxRow;

namespace InvoiceKu.Settings
{
    public interface ISalesTaxListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesTaxListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISalesTaxListHandler
    {
        public SalesTaxListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}