using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Settings.PurchaseTaxRow;

namespace InvoiceKu.Settings
{
    public interface IPurchaseTaxDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PurchaseTaxDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPurchaseTaxDeleteHandler
    {
        public PurchaseTaxDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}