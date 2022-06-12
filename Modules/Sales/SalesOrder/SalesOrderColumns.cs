using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace InvoiceKu.Sales.Columns
{
    [ColumnsScript("Sales.SalesOrder")]
    [BasedOnRow(typeof(SalesOrderRow), CheckNames = true)]
    public class SalesOrderColumns
    {
        [EditLink]
        public string Number { get; set; }
        public DateTime OrderDate { get; set; }
        [Width(200)]
        public int CustomerId { get; set; }
        public double SubTotal { get; set; }
        public int TenantId { get; set; }
    }
}