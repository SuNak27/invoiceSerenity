using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Sales.CustomerContactRow>;
using MyRow = InvoiceKu.Sales.CustomerContactRow;

namespace InvoiceKu.Sales
{
    public interface ICustomerContactRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerContactRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerContactRetrieveHandler
    {
        public CustomerContactRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}