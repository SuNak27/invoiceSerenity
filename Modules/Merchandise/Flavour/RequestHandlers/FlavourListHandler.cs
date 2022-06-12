using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Merchandise.FlavourRow>;
using MyRow = InvoiceKu.Merchandise.FlavourRow;

namespace InvoiceKu.Merchandise
{
    public interface IFlavourListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class FlavourListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IFlavourListHandler
    {
        public FlavourListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}