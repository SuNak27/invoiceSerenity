﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Administration.TenantRow;

namespace InvoiceKu.Administration
{
    public interface ITenantDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TenantDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITenantDeleteHandler
    {
        public TenantDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}