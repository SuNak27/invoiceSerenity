using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Sales.CustumerContactRow>;
using MyRow = InvoiceKu.Sales.CustumerContactRow;

namespace InvoiceKu.Sales
{
    public interface ICustumerContactRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustumerContactRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICustumerContactRetrieveHandler
    {
        public CustumerContactRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}