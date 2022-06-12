using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Purchase.BillRow;

namespace InvoiceKu.Purchase
{
    public interface IBillDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BillDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBillDeleteHandler
    {
        public BillDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}