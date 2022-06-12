using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Merchandise.SizeRow>;
using MyRow = InvoiceKu.Merchandise.SizeRow;

namespace InvoiceKu.Merchandise
{
    public interface ISizeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SizeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISizeListHandler
    {
        public SizeListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}