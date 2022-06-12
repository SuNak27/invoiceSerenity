using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Merchandise.ProductRow>;
using MyRow = InvoiceKu.Merchandise.ProductRow;

namespace InvoiceKu.Merchandise
{
    public interface IProductRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProductRetrieveHandler
    {
        public ProductRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}