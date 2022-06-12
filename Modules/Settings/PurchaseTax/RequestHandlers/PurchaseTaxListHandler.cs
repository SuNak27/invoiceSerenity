using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Settings.PurchaseTaxRow>;
using MyRow = InvoiceKu.Settings.PurchaseTaxRow;

namespace InvoiceKu.Settings
{
    public interface IPurchaseTaxListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseTaxListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseTaxListHandler
    {
        public PurchaseTaxListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}