using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Sales.CustumerContactRow;

namespace InvoiceKu.Sales
{
    public interface ICustumerContactDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CustumerContactDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICustumerContactDeleteHandler
    {
        public CustumerContactDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}