using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Sales.CustomerContactRow>;
using MyRow = InvoiceKu.Sales.CustomerContactRow;

namespace InvoiceKu.Sales
{
    public interface ICustomerContactListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerContactListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerContactListHandler
    {
        public CustomerContactListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}