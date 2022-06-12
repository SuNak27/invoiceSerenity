using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Merchandise.ProductRow;

namespace InvoiceKu.Merchandise
{
    public interface IProductDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ProductDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProductDeleteHandler
    {
        public ProductDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}