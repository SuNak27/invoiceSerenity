using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Merchandise.FlavourRow>;
using MyRow = InvoiceKu.Merchandise.FlavourRow;

namespace InvoiceKu.Merchandise
{
    public interface IFlavourRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class FlavourRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IFlavourRetrieveHandler
    {
        public FlavourRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}