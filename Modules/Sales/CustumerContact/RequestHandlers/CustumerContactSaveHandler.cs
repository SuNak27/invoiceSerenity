using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Sales.CustumerContactRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Sales.CustumerContactRow;

namespace InvoiceKu.Sales
{
    public interface ICustumerContactSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustumerContactSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICustumerContactSaveHandler
    {
        public CustumerContactSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}