using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Merchandise.BrandRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Merchandise.BrandRow;

namespace InvoiceKu.Merchandise
{
    public interface IBrandSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BrandSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBrandSaveHandler
    {
        public BrandSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}