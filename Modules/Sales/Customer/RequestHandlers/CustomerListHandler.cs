using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Sales.CustomerRow>;
using MyRow = InvoiceKu.Sales.CustomerRow;

namespace InvoiceKu.Sales
{
    public interface ICustomerListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerListHandler
    {
        public CustomerListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}