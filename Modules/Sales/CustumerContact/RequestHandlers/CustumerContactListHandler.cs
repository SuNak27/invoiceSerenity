using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Sales.CustumerContactRow>;
using MyRow = InvoiceKu.Sales.CustumerContactRow;

namespace InvoiceKu.Sales
{
    public interface ICustumerContactListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CustumerContactListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICustumerContactListHandler
    {
        public CustumerContactListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}