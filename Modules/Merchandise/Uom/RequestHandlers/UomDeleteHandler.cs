using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Merchandise.UomRow;

namespace InvoiceKu.Merchandise
{
    public interface IUomDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class UomDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUomDeleteHandler
    {
        public UomDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}