using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Administration.TenantRow>;
using MyRow = InvoiceKu.Administration.TenantRow;

namespace InvoiceKu.Administration
{
    public interface ITenantListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITenantListHandler
    {
        public TenantListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}