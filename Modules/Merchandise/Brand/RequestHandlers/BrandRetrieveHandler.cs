using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Merchandise.BrandRow>;
using MyRow = InvoiceKu.Merchandise.BrandRow;

namespace InvoiceKu.Merchandise
{
    public interface IBrandRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BrandRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBrandRetrieveHandler
    {
        public BrandRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}