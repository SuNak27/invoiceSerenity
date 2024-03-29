﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InvoiceKu.Sales.CustomerRow;

namespace InvoiceKu.Sales
{
    public interface ICustomerDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerDeleteHandler
    {
        public CustomerDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}