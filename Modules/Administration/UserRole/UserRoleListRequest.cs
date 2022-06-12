using Serenity.Services;

namespace InvoiceKu.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}