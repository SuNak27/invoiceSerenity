using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Settings.CashBankRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Settings.CashBankRow;

namespace InvoiceKu.Settings
{
    public interface ICashBankSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CashBankSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICashBankSaveHandler
    {
        public CashBankSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}