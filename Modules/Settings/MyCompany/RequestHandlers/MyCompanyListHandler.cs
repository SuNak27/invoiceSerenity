using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Settings.MyCompanyRow>;
using MyRow = InvoiceKu.Settings.MyCompanyRow;

namespace InvoiceKu.Settings
{
    public interface IMyCompanyListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MyCompanyListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMyCompanyListHandler
    {
        public MyCompanyListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}