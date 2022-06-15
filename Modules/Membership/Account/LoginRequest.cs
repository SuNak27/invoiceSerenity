using Serenity.ComponentModel;
using Serenity.Services;

namespace InvoiceKu.Membership
{
  [FormScript("Membership.Login")]
  [BasedOnRow(typeof(Administration.Entities.UserRow), CheckNames = true)]
  public class LoginRequest : ServiceRequest
  {
    [Placeholder("Username")]
    public string Username { get; set; }
    [PasswordEditor, Placeholder("******"), Required(true)]
    public string Password { get; set; }
  }
}