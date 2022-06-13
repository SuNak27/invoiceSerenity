using Serenity.Data;

namespace InvoiceKu
{
    public interface IMultiTenantRow
    {
        Int32Field TenantIdField { get; }
    }
}
