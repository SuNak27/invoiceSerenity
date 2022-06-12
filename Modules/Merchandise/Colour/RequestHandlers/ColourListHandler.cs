using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Merchandise.ColourRow>;
using MyRow = InvoiceKu.Merchandise.ColourRow;

namespace InvoiceKu.Merchandise
{
    public interface IColourListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ColourListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IColourListHandler
    {
        public ColourListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}