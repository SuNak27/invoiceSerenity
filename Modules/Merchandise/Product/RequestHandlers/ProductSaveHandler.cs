using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Merchandise.ProductRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Merchandise.ProductRow;

namespace InvoiceKu.Merchandise
{
    public interface IProductSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProductSaveHandler
    {
        public ProductSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}