using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Merchandise.SizeRow>;
using MyRow = InvoiceKu.Merchandise.SizeRow;

namespace InvoiceKu.Merchandise
{
    public interface ISizeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SizeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISizeRetrieveHandler
    {
        public SizeRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}