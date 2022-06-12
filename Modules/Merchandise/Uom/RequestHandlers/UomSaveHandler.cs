using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Merchandise.UomRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Merchandise.UomRow;

namespace InvoiceKu.Merchandise
{
    public interface IUomSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class UomSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUomSaveHandler
    {
        public UomSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}