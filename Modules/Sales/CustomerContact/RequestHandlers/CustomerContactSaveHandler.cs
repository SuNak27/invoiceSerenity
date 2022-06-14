using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Sales.CustomerContactRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Sales.CustomerContactRow;

namespace InvoiceKu.Sales
{
    public interface ICustomerContactSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerContactSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerContactSaveHandler
    {
        public CustomerContactSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}