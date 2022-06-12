using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Merchandise.ProductRow>;
using MyRow = InvoiceKu.Merchandise.ProductRow;

namespace InvoiceKu.Merchandise
{
    public interface IProductListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProductListHandler
    {
        public ProductListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}