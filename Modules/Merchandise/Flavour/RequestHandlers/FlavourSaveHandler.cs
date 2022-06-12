using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<InvoiceKu.Merchandise.FlavourRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InvoiceKu.Merchandise.FlavourRow;

namespace InvoiceKu.Merchandise
{
    public interface IFlavourSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class FlavourSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IFlavourSaveHandler
    {
        public FlavourSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}