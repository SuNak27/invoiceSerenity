using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Settings.CashBankRow>;
using MyRow = InvoiceKu.Settings.CashBankRow;

namespace InvoiceKu.Settings
{
    public interface ICashBankListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CashBankListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICashBankListHandler
    {
        public CashBankListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}