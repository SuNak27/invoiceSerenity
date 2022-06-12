using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Settings.CashBankRow>;
using MyRow = InvoiceKu.Settings.CashBankRow;

namespace InvoiceKu.Settings
{
    public interface ICashBankRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CashBankRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICashBankRetrieveHandler
    {
        public CashBankRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}